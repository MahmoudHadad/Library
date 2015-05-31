using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class RetriveInformation : Form
    {
        public RetriveInformation()
        {
            InitializeComponent();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            string student_ID = studentIDRetriveAllForms.Text.ToString();

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select *  from Borrow_list  where Borrow_list.Student_ID = '" + student_ID + "'" , con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridRetriveStudentForms.DataSource = ds.Tables["ss"];
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }

        }

        private void retriveStudent_Click(object sender, EventArgs e)
        {
            string student_ID = studnetIDRetriveStudent.Text;
            
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student where Student.Student_ID = '" + student_ID + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridRetriveStudent.DataSource = ds.Tables["ss"];
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }

        }

        private void RetriveInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.Borrow_list' table. You can move, or remove it, as needed.
            this.borrow_listTableAdapter.Fill(this.libraryDataSet1.Borrow_list);

        }

        private void dataGridRetriveStudentForms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridRetriveStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
