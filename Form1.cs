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
    public partial class Form1 : Form
    {
        internal static Form1 f1;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        private DatabaseAccess da;
        private OleDbDataReader dr;
        OleDbCommand cmd;
        OleDbConnection conn;
        

        /*  private void anmeldenAdmin()
          {
              if (txtBenutzer.Text == "admin" && txtPasswort.Text == "123")
              {
                  panel1.Visible = false;
                  panel2.Visible = true;

                  var form2 = new Form2();
                  form2.ShowDialog();

                  this.Close();
              }

              else
              {
                  txtBenutzer.Focus();
                  panel3.Visible = true;
                  txtBenutzer.Text = "";
                  txtPasswort.Text = "";
              }
          }

          private void anmeldenMitarbeiter()
          {
              if (txtBenutzer.Text == "mitarbeiter" && txtPasswort.Text == "1")
              {
                  panel1.Visible = false;
                  panel2.Visible = true;

                  var form4 = new Form4();
                  form4.ShowDialog();

                  this.Close();
              }

              else
              {
                  txtBenutzer.Focus();
                  panel3.Visible = true;
                  txtBenutzer.Text = "";
                  txtPasswort.Text = "";
              }
          }


          private void btnAnmeldung_Click(object sender, EventArgs e)
          {
              anmeldenAdmin();
              anmeldenMitarbeiter();
          }
          */

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new DatabaseAccess();
        }

        private void btnAnmeldung_Click(object sender, EventArgs e)
        {
           // int z = 0;
            
          
                
                cmd = new OleDbCommand();
                cmd.Connection = da.conn;
              //  cmd = new OleDbCommand("Select count(*) from Mitarbeiter where Benutzername = '" + txtBenutzer.Text + "'and Passwort =' " + txtPasswort.Text + "'", conn);
                cmd.CommandText = "SELECT * FROM Mitarbeiter where  Benutzername= '" + txtBenutzer.Text + "'";
                cmd.CommandText = "SELECT * FROM Mitarbeiter where  Passwort= '" + txtPasswort.Text + "'";
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Benutzername und Passwort sind korrekt");
                }
              //  cmd.Connection = conn;

                /*if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    z = (int)cmd.ExecuteScalar();
                }
                conn.Close();
               */
               // if (z == 1)
                //{
                   // MessageBox.Show("Benutzername und Passwort sind korrekt");
                    //this.Hide();
                    //Form2 f2 = new Form2();
                //}
                //else if(z == 2)
                //{
                  //  this.Hide();
                    //Form3 f3 = new Form3();
                //}
                else
                {
                    MessageBox.Show("nicht korrekt");
                }
                
            

           
        }
    }
}
