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
    public partial class Form3 : Form
    {
        internal static Form3 f3;
        public Form3()
        {
            f3 = this;
            InitializeComponent();
        }
        string cn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DatenbankVerkauf.accdb";
        OleDbConnection conn;
        DatabaseAccess da;
        OleDbDataReader dr;
        OleDbCommand cmd;
        internal long pid;
        Form2 f2 = new Form2();
        string sql;

        private void Form3_Load(object sender, EventArgs e)
        {

            f2.readProduktIntoListView();
            da = new DatabaseAccess();
            if (this.Text.Equals("Neues Produkt anlegen"))
            {
                label1.Visible = false;
                txtProduktID.Visible = false;
            }
            else //Bearbeiten
            {

                for (int i = 0; i < f2.Produktlist.Count; i++)
                {
                    if (pid == f2.Produktlist[i].ProduktID)
                    {
                       
                        txtProduktID.Text = f2.Produktlist[i].ProduktID.ToString();
                        txtBezeichnung.Text = f2.Produktlist[i].Bezeichnug;
                        txtMenge.Text = f2.Produktlist[i].Menge.ToString();
                        txtPreis.Text = f2.Produktlist[i].Preis.ToString();
                    }
                }
            }
        }

      

        private void speichernToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (txtPreis.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie den Preis ein!");
                return;
            }

            else if (txtBezeichnung.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie die Bezeichnung ein!");
                return;
            }

            else if (txtMenge.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie die Menge ein!");
                return;
            }

            if (this.Text.Equals("Neues Produkt anlegen"))
            {
                // In Tabelle einfügen
                sql = "Insert into Produkt (Preis, Bezeichnung, Menge) values (?, ?, ?)";
                cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new OleDbParameter("Preis", txtPreis.Text));
                cmd.Parameters.Add(new OleDbParameter("Bezeichnung", txtBezeichnung.Text));
                cmd.Parameters.Add(new OleDbParameter("Menge", txtMenge.Text));
              //  cmd.Parameters.Add(new OleDbParameter("ProduktID", Convert.ToInt64(txtProduktID.Text)));
                da.executeQuery(cmd);

                //ProduktID des neu erstellten Produkts auslesen
                sql = "Select Max(ProduktID) from Produkt;";
                long pid = da.executeScalar(sql);


                MessageBox.Show("Das Produkt wurde erfolgreich angelegt!");

            }
            else  //Bearbeiten
            {

                sql = "Update Produkt set Preis=?, Bezeichnung=?, Menge=?  where ProduktID=?";
                cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new OleDbParameter("Preis", Convert.ToDouble(txtPreis.Text)));
                cmd.Parameters.Add(new OleDbParameter("Bezeichnung", txtBezeichnung.Text));
                cmd.Parameters.Add(new OleDbParameter("Menge", Convert.ToInt64(txtMenge.Text)));
                cmd.Parameters.Add(new OleDbParameter("ProduktID", Convert.ToInt64(txtProduktID.Text)));
                da.executeQuery(cmd);

               

                MessageBox.Show("Das Produkt wurde erfolgreich bearbeitet!");

            }
            MessageBox.Show("Nach neu einlesen!");
            this.Close();
        }

        private void beendenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

