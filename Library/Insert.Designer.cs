namespace Library
{
    partial class Insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDBorrow = new System.Windows.Forms.TextBox();
            this.bookIDBorrow = new System.Windows.Forms.TextBox();
            this.adminIDBorrow = new System.Windows.Forms.TextBox();
            this.CreateBorrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateReturn = new System.Windows.Forms.Button();
            this.adminIDReturn = new System.Windows.Forms.TextBox();
            this.studentIDReturn = new System.Windows.Forms.TextBox();
            this.bookIDReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 122);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create new borrwo form\r\nAdmin ID\r\n\r\nStudent ID\r\n\r\nBook ID";
            // 
            // studentIDBorrow
            // 
            this.studentIDBorrow.Location = new System.Drawing.Point(189, 60);
            this.studentIDBorrow.Name = "studentIDBorrow";
            this.studentIDBorrow.Size = new System.Drawing.Size(193, 23);
            this.studentIDBorrow.TabIndex = 5;
            // 
            // bookIDBorrow
            // 
            this.bookIDBorrow.Location = new System.Drawing.Point(189, 108);
            this.bookIDBorrow.Name = "bookIDBorrow";
            this.bookIDBorrow.Size = new System.Drawing.Size(193, 23);
            this.bookIDBorrow.TabIndex = 6;
            // 
            // adminIDBorrow
            // 
            this.adminIDBorrow.Location = new System.Drawing.Point(189, 31);
            this.adminIDBorrow.Name = "adminIDBorrow";
            this.adminIDBorrow.Size = new System.Drawing.Size(193, 23);
            this.adminIDBorrow.TabIndex = 7;
            // 
            // CreateBorrow
            // 
            this.CreateBorrow.Location = new System.Drawing.Point(126, 147);
            this.CreateBorrow.Name = "CreateBorrow";
            this.CreateBorrow.Size = new System.Drawing.Size(138, 36);
            this.CreateBorrow.TabIndex = 8;
            this.CreateBorrow.Text = "Create Borrow Form";
            this.CreateBorrow.UseVisualStyleBackColor = true;
            this.CreateBorrow.Click += new System.EventHandler(this.CreateBorrow_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 164);
            this.label3.TabIndex = 9;
            this.label3.Text = "Create new return form\r\n\r\nAdmin ID\r\n\r\nStudent ID\r\n\r\nBook ID";
            // 
            // CreateReturn
            // 
            this.CreateReturn.Location = new System.Drawing.Point(126, 369);
            this.CreateReturn.Name = "CreateReturn";
            this.CreateReturn.Size = new System.Drawing.Size(138, 33);
            this.CreateReturn.TabIndex = 10;
            this.CreateReturn.Text = "Create Return Form";
            this.CreateReturn.UseVisualStyleBackColor = true;
            this.CreateReturn.Click += new System.EventHandler(this.CreateReturn_Click);
            // 
            // adminIDReturn
            // 
            this.adminIDReturn.Location = new System.Drawing.Point(189, 241);
            this.adminIDReturn.Name = "adminIDReturn";
            this.adminIDReturn.Size = new System.Drawing.Size(193, 23);
            this.adminIDReturn.TabIndex = 11;
            // 
            // studentIDReturn
            // 
            this.studentIDReturn.Location = new System.Drawing.Point(189, 281);
            this.studentIDReturn.Name = "studentIDReturn";
            this.studentIDReturn.Size = new System.Drawing.Size(193, 23);
            this.studentIDReturn.TabIndex = 12;
            // 
            // bookIDReturn
            // 
            this.bookIDReturn.Location = new System.Drawing.Point(189, 321);
            this.bookIDReturn.Name = "bookIDReturn";
            this.bookIDReturn.Size = new System.Drawing.Size(193, 23);
            this.bookIDReturn.TabIndex = 13;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 414);
            this.Controls.Add(this.bookIDReturn);
            this.Controls.Add(this.studentIDReturn);
            this.Controls.Add(this.adminIDReturn);
            this.Controls.Add(this.CreateReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateBorrow);
            this.Controls.Add(this.adminIDBorrow);
            this.Controls.Add(this.bookIDBorrow);
            this.Controls.Add(this.studentIDBorrow);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDBorrow;
        private System.Windows.Forms.TextBox bookIDBorrow;
        private System.Windows.Forms.TextBox adminIDBorrow;
        private System.Windows.Forms.Button CreateBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateReturn;
        private System.Windows.Forms.TextBox adminIDReturn;
        private System.Windows.Forms.TextBox studentIDReturn;
        private System.Windows.Forms.TextBox bookIDReturn;
    }
}