namespace Library
{
    partial class RetriveInformation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.studentIDRetriveAllForms = new System.Windows.Forms.TextBox();
            this.retriveStudentBorrowForms = new System.Windows.Forms.Button();
            this.dataGridRetriveStudentForms = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.studnetIDRetriveStudent = new System.Windows.Forms.TextBox();
            this.dataGridRetriveStudent = new System.Windows.Forms.DataGridView();
            this.retriveStudent = new System.Windows.Forms.Button();
            this.libraryDataSet = new Library.LibraryDataSet();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Library.LibraryDataSet1();
            this.borrowlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrow_listTableAdapter = new Library.LibraryDataSet1TableAdapters.Borrow_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetriveStudentForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetriveStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retrive all borrow forms for a student\r\n\r\nEnter Student ID";
            // 
            // studentIDRetriveAllForms
            // 
            this.studentIDRetriveAllForms.Location = new System.Drawing.Point(324, 51);
            this.studentIDRetriveAllForms.Name = "studentIDRetriveAllForms";
            this.studentIDRetriveAllForms.Size = new System.Drawing.Size(149, 20);
            this.studentIDRetriveAllForms.TabIndex = 1;
            // 
            // retriveStudentBorrowForms
            // 
            this.retriveStudentBorrowForms.Location = new System.Drawing.Point(197, 176);
            this.retriveStudentBorrowForms.Name = "retriveStudentBorrowForms";
            this.retriveStudentBorrowForms.Size = new System.Drawing.Size(112, 28);
            this.retriveStudentBorrowForms.TabIndex = 2;
            this.retriveStudentBorrowForms.Text = "Retrive Forms";
            this.retriveStudentBorrowForms.UseVisualStyleBackColor = true;
            this.retriveStudentBorrowForms.Click += new System.EventHandler(this.retriveButton_Click);
            // 
            // dataGridRetriveStudentForms
            // 
            this.dataGridRetriveStudentForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRetriveStudentForms.Location = new System.Drawing.Point(16, 77);
            this.dataGridRetriveStudentForms.Name = "dataGridRetriveStudentForms";
            this.dataGridRetriveStudentForms.Size = new System.Drawing.Size(457, 93);
            this.dataGridRetriveStudentForms.TabIndex = 3;
            this.dataGridRetriveStudentForms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRetriveStudentForms_CellContentClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 70);
            this.label2.TabIndex = 4;
            this.label2.Text = "Show student information\r\n\r\nEnter Student ID";
            // 
            // studnetIDRetriveStudent
            // 
            this.studnetIDRetriveStudent.Location = new System.Drawing.Point(324, 257);
            this.studnetIDRetriveStudent.Name = "studnetIDRetriveStudent";
            this.studnetIDRetriveStudent.Size = new System.Drawing.Size(205, 20);
            this.studnetIDRetriveStudent.TabIndex = 5;
            // 
            // dataGridRetriveStudent
            // 
            this.dataGridRetriveStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRetriveStudent.Location = new System.Drawing.Point(20, 300);
            this.dataGridRetriveStudent.Name = "dataGridRetriveStudent";
            this.dataGridRetriveStudent.Size = new System.Drawing.Size(509, 62);
            this.dataGridRetriveStudent.TabIndex = 6;
            this.dataGridRetriveStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRetriveStudent_CellContentClick);
            // 
            // retriveStudent
            // 
            this.retriveStudent.Location = new System.Drawing.Point(197, 368);
            this.retriveStudent.Name = "retriveStudent";
            this.retriveStudent.Size = new System.Drawing.Size(112, 28);
            this.retriveStudent.TabIndex = 7;
            this.retriveStudent.Text = "Retrive Student";
            this.retriveStudent.UseVisualStyleBackColor = true;
            this.retriveStudent.Click += new System.EventHandler(this.retriveStudent_Click);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowlistBindingSource
            // 
            this.borrowlistBindingSource.DataMember = "Borrow_list";
            this.borrowlistBindingSource.DataSource = this.libraryDataSet1;
            // 
            // borrow_listTableAdapter
            // 
            this.borrow_listTableAdapter.ClearBeforeFill = true;
            // 
            // RetriveInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 408);
            this.Controls.Add(this.retriveStudent);
            this.Controls.Add(this.dataGridRetriveStudent);
            this.Controls.Add(this.studnetIDRetriveStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridRetriveStudentForms);
            this.Controls.Add(this.retriveStudentBorrowForms);
            this.Controls.Add(this.studentIDRetriveAllForms);
            this.Controls.Add(this.label1);
            this.Name = "RetriveInformation";
            this.Text = "RetriveInformation";
            this.Load += new System.EventHandler(this.RetriveInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetriveStudentForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRetriveStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowlistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentIDRetriveAllForms;
        private System.Windows.Forms.Button retriveStudentBorrowForms;
        private System.Windows.Forms.DataGridView dataGridRetriveStudentForms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studnetIDRetriveStudent;
        private System.Windows.Forms.DataGridView dataGridRetriveStudent;
        private System.Windows.Forms.Button retriveStudent;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource borrowlistBindingSource;
        private LibraryDataSet1TableAdapters.Borrow_listTableAdapter borrow_listTableAdapter;
    }
}