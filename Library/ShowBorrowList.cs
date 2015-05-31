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
    public partial class ShowBorrowList : Form
    {
        public ShowBorrowList()
        {
            InitializeComponent();
        }

        private void ShowBorrowList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.Borrow_list' table. You can move, or remove it, as needed.
            this.borrow_listTableAdapter.Fill(this.libraryDataSet2.Borrow_list);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand(" select Student.Student_FirstName ,Student.Student_LastName ,Borrow_list.Student_ID,Borrow_list.Book_ID ,Borrow_list.Borrow_list_Date ,Borrow_list.Admin_ID from Borrow_list join Student on Student.Student_ID = Borrow_list.Student_ID ", con);
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
