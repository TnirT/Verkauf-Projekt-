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

        private DatabaseAccess da;
        private OleDbDataReader dr;

        OleDbCommand cmd;
        string sql;
        ListViewItem lvItem;

        private void Form2_Load(object sender, EventArgs e)
        {
            da = new DatabaseAccess();
            readDatenintoList();
        }
    }
}
