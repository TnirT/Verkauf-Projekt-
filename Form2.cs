using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Verkauf
{
    public partial class Form2 : Form
    {
        internal static Form2 f2;
        public Form2()
        {
            f2 = this;
            InitializeComponent();
        }

         DatabaseAccess da=new DatabaseAccess();
         OleDbDataReader dr;
        internal List<Produkt> Produktlist = new List<Produkt>();
        string cn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DatenbankVerkauf.accdb";
        OleDbConnection conn;
        
       
        OleDbCommand cmd;
        string sql;
        ListViewItem lvItem;
       // internal long ProID;

        private void Form2_Load(object sender, EventArgs e)
        {
            readProduktIntoListView();
            listView1.FullRowSelect = true;
        }

        //internal void readProduktintoList()
        //{
        //    Produktlist = new List<Produkt>();
        //    dr = da.readData("Select * from viewProdukt");
        //    while (dr.Read())
        //    {
        //        Produktlist.Add(new Produkt(Convert.ToInt64(dr[0].ToString()), Convert.ToInt64(dr[1].ToString()), dr[3].ToString(), Convert.ToInt64(dr[2].ToString())));
        //      //  Produktlist.Add(new Produkt(Convert.ToInt64(dr[0].ToString()), (dr[1].ToString()),  (dr[3].ToString())), dr[2].ToString());
        //    }
        //}

        internal void readProduktIntoListView()
        {

            conn = new OleDbConnection(cn);
            //dr = da.readData("Select * from Produkt");
            conn.Open();
            sql= "SELECT * FROM Produkt";
            cmd = new OleDbCommand(sql,conn);
            //cmd.Connection = da.conn;
            //cmd.CommandText = "SELECT * FROM Produkt";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lvItem);

                Produktlist.Add(new Produkt(Convert.ToInt64(dr[0].ToString()), Convert.ToDouble(dr[1].ToString()), dr[2].ToString(), Convert.ToInt64(dr[3].ToString())));
            }
            conn.Close();
        }

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Text = "Neues Produkt anlegen";
            f3.ShowDialog();
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt zum Bearbeiten aus");
                return;
            }
            Form3 f3 = new Form3();
            f3.pid= Convert.ToInt64(listView1.SelectedItems[0].SubItems[0].Text.ToString());
            f3.Text = "Produkt bearbeiten";
            f3.ShowDialog();

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt zum Löschen aus!");
                return;
            }
            lvItem = listView1.SelectedItems[0];
            long produktid = Convert.ToInt64(lvItem.SubItems[0].Text);
            foreach (Produkt f in Produktlist)
            {
                if (f.ProduktID == produktid)
            {
                //MessageBox.Show("gefunden!");
                sql = "Delete * from Produkt where ProduktID = ?;";
                    cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("ProduktID", produktid);
                    break;
                    //cmd.Parameters.AddWithValue("Preis", Produktlist[0].ProduktID);
                    //cmd.Parameters.AddWithValue("ProduktID", produktid);
                    //da.executeQuery(cmd);
                   
            }
        }
       
            

            
    }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
