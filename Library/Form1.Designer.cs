namespace Library
{
    partial class Form1
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
            this.addList = new System.Windows.Forms.Button();
            this.updateDelete = new System.Windows.Forms.Button();
            this.retrive = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ShowBooks = new System.Windows.Forms.Button();
            this.showBorrwo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addList
            // 
            this.addList.AccessibleDescription = "";
            this.addList.Location = new System.Drawing.Point(87, 40);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(210, 48);
            this.addList.TabIndex = 0;
            this.addList.Text = "Add List";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateDelete
            // 
            this.updateDelete.Location = new System.Drawing.Point(87, 119);
            this.updateDelete.Name = "updateDelete";
            this.updateDelete.Size = new System.Drawing.Size(210, 52);
            this.updateDelete.TabIndex = 1;
            this.updateDelete.Text = "Update or Delete books";
            this.updateDelete.UseVisualStyleBackColor = true;
            this.updateDelete.Click += new System.EventHandler(this.updateDelete_Click);
            // 
            // retrive
            // 
            this.retrive.Location = new System.Drawing.Point(87, 200);
            this.retrive.Name = "retrive";
            this.retrive.Size = new System.Drawing.Size(210, 48);
            this.retrive.TabIndex = 2;
            this.retrive.Text = "Retrive Information";
            this.retrive.UseVisualStyleBackColor = true;
            this.retrive.Click += new System.EventHandler(this.retrive_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(87, 542);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(210, 40);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ShowBooks
            // 
            this.ShowBooks.Location = new System.Drawing.Point(87, 279);
            this.ShowBooks.Name = "ShowBooks";
            this.ShowBooks.Size = new System.Drawing.Size(210, 48);
            this.ShowBooks.TabIndex = 4;
            this.ShowBooks.Text = "Show Available books";
            this.ShowBooks.UseVisualStyleBackColor = true;
            this.ShowBooks.Click += new System.EventHandler(this.ShowBooks_Click);
            // 
            // showBorrwo
            // 
            this.showBorrwo.Location = new System.Drawing.Point(87, 344);
            this.showBorrwo.Name = "showBorrwo";
            this.showBorrwo.Size = new System.Drawing.Size(210, 45);
            this.showBorrwo.TabIndex = 5;
            this.showBorrwo.Text = "Show All Borrow Forms";
            this.showBorrwo.UseVisualStyleBackColor = true;
            this.showBorrwo.Click += new System.EventHandler(this.showBorrwo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show Statistics about borrowed books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show Reports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBorrwo);
            this.Controls.Add(this.ShowBooks);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.retrive);
            this.Controls.Add(this.updateDelete);
            this.Controls.Add(this.addList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.Button updateDelete;
        private System.Windows.Forms.Button retrive;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ShowBooks;
        private System.Windows.Forms.Button showBorrwo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

