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
    public partial class BooksInDepartment : Form
    {
        public BooksInDepartment()
        {
           

            InitializeComponent();
          
        }

        private void showButton_Click(object sender, EventArgs e)
        {


            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand(" select distinct Book_Name as[Book Name] , Book_ID from  Book inner join Department on Book.Department_ID ='" + departmentID.Text.ToString() + "'" + "and Book_ID not in(	select Book_ID	from Borrow_list) order by Book_Name", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView1.DataSource = ds.Tables["ss"];
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
           

        }
    }
}
