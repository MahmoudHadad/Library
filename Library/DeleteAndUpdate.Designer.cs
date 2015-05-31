namespace Library
{
    partial class DeleteAndUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bookIDDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookIDUpdate = new System.Windows.Forms.TextBox();
            this.bookEditionUpdate = new System.Windows.Forms.TextBox();
            this.doneUpdate = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO Delete Book \r\nEnter Book ID\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(100, 119);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bookIDDelete
            // 
            this.bookIDDelete.Location = new System.Drawing.Point(150, 46);
            this.bookIDDelete.Name = "bookIDDelete";
            this.bookIDDelete.Size = new System.Drawing.Size(157, 20);
            this.bookIDDelete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(172, 126);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Update Book Edition\r\nEnter Book ID\r\n\r\nEnter New Edition";
            // 
            // bookIDUpdate
            // 
            this.bookIDUpdate.Location = new System.Drawing.Point(181, 218);
            this.bookIDUpdate.Name = "bookIDUpdate";
            this.bookIDUpdate.Size = new System.Drawing.Size(126, 20);
            this.bookIDUpdate.TabIndex = 5;
            this.bookIDUpdate.TextChanged += new System.EventHandler(this.bookIDUpdate_TextChanged);
            // 
            // bookEditionUpdate
            // 
            this.bookEditionUpdate.Location = new System.Drawing.Point(181, 255);
            this.bookEditionUpdate.Name = "bookEditionUpdate";
            this.bookEditionUpdate.Size = new System.Drawing.Size(126, 20);
            this.bookEditionUpdate.TabIndex = 6;
            // 
            // doneUpdate
            // 
            this.doneUpdate.AutoSize = true;
            this.doneUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneUpdate.Location = new System.Drawing.Point(96, 299);
            this.doneUpdate.Name = "doneUpdate";
            this.doneUpdate.Size = new System.Drawing.Size(0, 19);
            this.doneUpdate.TabIndex = 7;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(100, 321);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // DeleteAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 351);
            this.Controls.Add(this.update);
            this.Controls.Add(this.doneUpdate);
            this.Controls.Add(this.bookEditionUpdate);
            this.Controls.Add(this.bookIDUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookIDDelete);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAndUpdate";
            this.Text = "DeleteAndUpdate";
            this.Load += new System.EventHandler(this.DeleteAndUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox bookIDDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookIDUpdate;
        private System.Windows.Forms.TextBox bookEditionUpdate;
        private System.Windows.Forms.Label doneUpdate;
        private System.Windows.Forms.Button update;
    }
}