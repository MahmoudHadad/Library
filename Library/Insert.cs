using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;
namespace Library
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void Checkbutton_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select *  from Borrow_list  where Borrow_list.Student_ID = '" + student_ID + "'", con);
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
            */

        }

        private void CreateBorrow_Click(object sender, EventArgs e)
        {
            //-----------------connection with Database----------------------------//
            ErrorProvider errorProvider1 = new ErrorProvider();
           SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;
		   Initial Catalog=Library;Integrated Security=True");
           con.Open();
           SqlCommand cmd = new SqlCommand();
            

           if ( adminIDBorrow.Text.Trim() == "" || studentIDBorrow.Text.Trim() == "" || bookIDBorrow.Text.Trim() == "")
           {
               errorProvider1.SetError(adminIDBorrow, " Please Enter Valid Admin ID and a Student ID and Book ID ");
              errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
          }
           else
          {

              SqlCommand check = new SqlCommand("update Borrow_list set  Book_ID = Book_ID where Book_ID='" + bookIDBorrow.Text.ToString() + "' ", con);
              int success = check.ExecuteNonQuery();
              //MessageBox.Show(success+"");
              if (success != 0)
              {
                  MessageBox.Show( "This Book is Not Valid ");
                  con.Close();

                  return;
              }

              
              errorProvider1.Clear();
              cmd.Connection = con;
              SqlCommand myCommand = new SqlCommand("insert into Borrow_list values ('" + studentIDBorrow.Text.ToString() + "','" + bookIDBorrow.Text.ToString() + "','" + adminIDBorrow.Text.ToString() + "',GETDATE() )", con);
              success = myCommand.ExecuteNonQuery();
              if (success == 1)
                  MessageBox.Show("Form created successfully");
              con.Close(); 
           }
//////////////////////////////////////////////////////////
 
        }

        private void CreateReturn_Click(object sender, EventArgs e)
        {

            //-----------------connection with Database----------------------------//
            ErrorProvider errorProvider1 = new ErrorProvider();
            SqlConnection con = new SqlConnection(@"Data Source=MAHMOUDHADAD\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            

            if (adminIDReturn.Text.Trim() == "" || studentIDReturn.Text.Trim() == "" || bookIDReturn.Text.Trim() == "")
            {
                errorProvider1.SetError(adminIDReturn, " Please Enter Valid Admin ID and a Student ID and Book ID ");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                
          
        
            }
            else
            {
               
                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("insert into Return_list  values ('"+studentIDReturn.Text.ToString()+"','" + bookIDReturn.Text.ToString() + "','" + adminIDReturn.Text.ToString() + "',GETDATE() )" , con);
                SqlCommand myCommand2 = new SqlCommand("delete from Borrow_list  where Borrow_list.Student_ID  = '" + studentIDReturn.Text.ToString() + "'" + " and  Book_ID  = '" + bookIDReturn.Text.ToString() +"'", con);

                int success = myCommand.ExecuteNonQuery();
                success = myCommand2.ExecuteNonQuery();
                MessageBox.Show(success + " row has been inserted ");

                con.Close();
            }



            MessageBox.Show("Form created successfully\nBorrow form deleted from borrow list");
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void axCrystalActiveXReportViewer1_Enter(object sender, EventArgs e)
        {

        }

        private void studentIDCheck_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
