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
    public partial class Form4 : Form
    {
        internal static Form4 f4;

        public Form4()
        {
            f4 = this;
            InitializeComponent();
        }
        private OleDbDataReader dr;
        OleDbCommand cmd;
        string sql;
        ListViewItem lvItem;

        DatabaseAccess da = new DatabaseAccess();
        internal List<Rechnung> Rechnungsliste;

        Form2 f2 = new Form2();


        private void Form4_Load(object sender, EventArgs e)
        {
            Rechnungsliste = new List<Rechnung>();
            f2.readProduktIntoListView();
            
        }

        private void btE_Click(object sender, EventArgs e)
        {

            
          


           
            for (int i = 0; i < f2.Produktlist.Count; i++)
            {
                if (txtPID.Text.Equals(f2.Produktlist[i].ProduktID.ToString()))
                {


                    if (f2.Produktlist[i].Menge >= Convert.ToInt64(txtM.Text))
                    {


                    lvItem = new ListViewItem(f2.Produktlist[i].ProduktID.ToString());
                    lvItem.SubItems.Add(f2.Produktlist[i].Preis.ToString());
                    lvItem.SubItems.Add(f2.Produktlist[i].Bezeichnug);
                    lvItem.SubItems.Add(txtM.Text);
                    listView2.Items.Add(lvItem);

                       
                }
                    
                  
                    else
                    {
                        MessageBox.Show("Menge höher als Lagerbestand, es muss nachbestellt werden!");
                        continue;
                    }

                         

                    //  txtG.Text = Convert.ToString(Convert.ToDouble(txtM.Text) * Convert.ToDouble(lvItem.SubItems[2].Text));
                }

                

                double summe = 0;
                for (int z = 0; z < listView2.Items.Count; z++)
                {
                    summe += Convert.ToDouble(listView2.Items[z].SubItems[1].Text) * Convert.ToDouble(listView2.Items[z].SubItems[3].Text);
                    txtG.Text = summe.ToString();

                   
                }

                 


            }
        }



       
          
        



private void btRd_Click(object sender, EventArgs e)
        {
            for (int z = 0; z < listView2.Items.Count; z++)
            {
                MessageBox.Show(listView2.Items[z].SubItems[0].Text.ToString());
                Rechnungsliste.Add(new Rechnung(Convert.ToInt64(listView2.Items[z].SubItems[0].Text.ToString()), Convert.ToInt64(listView2.Items[z].SubItems[3].Text.ToString())));

                MessageBox.Show(Rechnungsliste[z].ProduktID.ToString()+ Rechnungsliste[z].Menge.ToString());
                for (int y = 0; y < f2.Produktlist.Count; y++)
                {
                    
                    if (f2.Produktlist[y].ProduktID == Rechnungsliste[z].ProduktID)
                    {

                        long sum = (Convert.ToInt64(f2.Produktlist[y].Menge.ToString()) - Convert.ToInt64(Rechnungsliste[z].Menge.ToString()));
                        MessageBox.Show(sum.ToString());


                        sql = "Update Produkt set Menge=? where ProduktID=?";
                        cmd = new OleDbCommand();
                        cmd.CommandText = sql;
                        cmd.Parameters.Add(new OleDbParameter("Menge", sum));
                        cmd.Parameters.Add(new OleDbParameter("ProduktID", f2.Produktlist[y].ProduktID));
                        da.executeQuery(cmd);
                    }
                }
               
            }





        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }
    }

        }
        
    

    

