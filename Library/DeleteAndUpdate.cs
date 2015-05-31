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
    public partial class DeleteAndUpdate : Form
    {
        public DeleteAndUpdate()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //-----------------connection with Database----------------------------//
            ErrorProvider errorProvider1 = new ErrorProvider();
            SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            
            /// connection
            /// 
           con.Open();
           errorProvider1.Clear();
           cmd.Connection = con;
           SqlCommand myCommand = new SqlCommand("delete from AuthorWriteBook  where Book_ID = '" + bookIDDelete.Text + "'     delete from Book where Book_ID = '" + bookIDDelete.Text + "'", con);
   
           MessageBox.Show( " Book has been Deleted");
           con.Close();
////////

           DeleteAndUpdate I = new DeleteAndUpdate();
            this.Hide();
            I.Show();
          
        }

        private void update_Click(object sender, EventArgs e)
        {
            //-----------------connection with Database----------------------------//
 ErrorProvider errorProvider1 = new ErrorProvider();
 SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

 SqlCommand cmd = new SqlCommand();



 
/////////////////////////////////////
 if (bookIDUpdate.Text.Trim() == "" || bookEditionUpdate.Text.Trim() == "")
 {
     errorProvider1.SetError(bookIDUpdate, " Please Enter Valid Book ID ");
     errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
 }
 else
 {
     con.Open();
     errorProvider1.Clear();
     cmd.Connection = con;
     SqlCommand myCommand = new SqlCommand("update Book set  Book_Edition   = '" + bookEditionUpdate.Text.ToString() + "'  where Book.Book_ID ='" + bookIDUpdate.Text.ToString() + "'", con);
     int success = myCommand.ExecuteNonQuery();
     MessageBox.Show(success + " row has been updated");
     con.Close();
 }
//////////////////////////////////////////////////////////


    DeleteAndUpdate I = new DeleteAndUpdate();
    this.Hide();
    I.Show();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookIDUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAndUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
