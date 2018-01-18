using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkauf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        }
    }
}
