using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert ins= new Insert();
            ins.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateDelete_Click(object sender, EventArgs e)
        {
            DeleteAndUpdate du = new DeleteAndUpdate();
            du.Show();
        }

        private void retrive_Click(object sender, EventArgs e)
        {
            RetriveInformation ret = new RetriveInformation();
            ret.Show();
        }

        private void ShowBooks_Click(object sender, EventArgs e)
        {
            BooksInDepartment b = new BooksInDepartment();
            b.Show();
        }

        private void showBorrwo_Click(object sender, EventArgs e)
        {
            ShowBorrowList sh = new ShowBorrowList() ;
            sh.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Statistics st = new Statistics();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
        }
    }
}
