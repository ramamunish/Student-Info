using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Focus();
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\support2\\Documents\\Visual Studio 2010\\Projects\\LoginApp\\Db\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            String query = "Select * from tbl_Login Where Username='" + txtusername.Text.Trim() + "' and password='" + txtpassword.Text.Trim() + "'";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmMain objectfrmmain = new frmMain();
                this.Hide();
                objectfrmmain.Show();
            }
            else
            {
                MessageBox.Show("Check Your Username and Password");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
