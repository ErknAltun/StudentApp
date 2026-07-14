namespace StudentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAge = new TextBox();
            txtGrade = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 2;
            label2.Text = "Yaş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 3;
            label3.Text = "Not:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(83, 61);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(226, 31);
            txtAge.TabIndex = 4;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(83, 98);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(226, 31);
            txtGrade.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(195, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 30);
            label1.TabIndex = 11;
            label1.Text = "Ad:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(83, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(83, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 36);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Location = new Point(769, 431);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 32);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Ara..";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(877, 432);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 31);
            txtSearch.TabIndex = 15;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(343, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(760, 408);
            dgvStudents.TabIndex = 16;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1115, 561);
            Controls.Add(dgvStudents);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtGrade);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Student App";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtAge;
        private TextBox txtGrade;
        private Button button1;
        private Button btnUpdate;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvStudents;
    }
}
