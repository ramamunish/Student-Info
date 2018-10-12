using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_management_system
{
    public partial class Student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\support2\Documents\Studentinfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Student_info()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Students Values(" + txt_studentid.Text +",'" + txt_stuName.Text +"','" + txt_address.Text +"','" + txt_email.Text+"','" +txt_class.Text +"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert data Sucessfully");
            con.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbl_Students SET Stu_Name='" + txt_stuName.Text + "',Address='" + txt_address.Text + "',Email= '"+ txt_email.Text +"',Class= '"+ txt_class.Text +"' WHERE Student_id= '"+ txt_studentid.Text +"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data Sucessfully");
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE tbl_Students WHERE Student_id='"+ txt_studentid.Text +"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data Sucessfully");
            con.Close();

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            con.Open();
            txt_studentid.Text = "";
            txt_stuName.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_class.Text = "";
            con.Close();

        }

    }
}
