namespace StudentManagement
{
    partial class Form3
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
            this.classIdLb = new System.Windows.Forms.Label();
            this.classIdTb = new System.Windows.Forms.TextBox();
            this.viewDetailBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.classIdViewTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.viewStudentsBtn = new System.Windows.Forms.Button();
            this.listStudentsView = new System.Windows.Forms.ListView();
            this.StudentID = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // classIdLb
            // 
            this.classIdLb.AutoSize = true;
            this.classIdLb.Location = new System.Drawing.Point(25, 74);
            this.classIdLb.Name = "classIdLb";
            this.classIdLb.Size = new System.Drawing.Size(99, 20);
            this.classIdLb.TabIndex = 0;
            this.classIdLb.Text = "Enter Class ID";
            // 
            // classIdTb
            // 
            this.classIdTb.Location = new System.Drawing.Point(130, 67);
            this.classIdTb.Name = "classIdTb";
            this.classIdTb.Size = new System.Drawing.Size(180, 27);
            this.classIdTb.TabIndex = 1;
            // 
            // viewDetailBtn
            // 
            this.viewDetailBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewDetailBtn.Location = new System.Drawing.Point(30, 134);
            this.viewDetailBtn.Name = "viewDetailBtn";
            this.viewDetailBtn.Size = new System.Drawing.Size(280, 62);
            this.viewDetailBtn.TabIndex = 2;
            this.viewDetailBtn.Text = "View in Detail";
            this.viewDetailBtn.UseVisualStyleBackColor = true;
            this.viewDetailBtn.Click += new System.EventHandler(this.viewDetailBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID";
            // 
            // classIdViewTb
            // 
            this.classIdViewTb.Enabled = false;
            this.classIdViewTb.Location = new System.Drawing.Point(130, 227);
            this.classIdViewTb.Name = "classIdViewTb";
            this.classIdViewTb.Size = new System.Drawing.Size(180, 27);
            this.classIdViewTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            // 
            // classNameTb
            // 
            this.classNameTb.Enabled = false;
            this.classNameTb.Location = new System.Drawing.Point(130, 278);
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.Size = new System.Drawing.Size(180, 27);
            this.classNameTb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // yearTb
            // 
            this.yearTb.Enabled = false;
            this.yearTb.Location = new System.Drawing.Point(130, 335);
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(180, 27);
            this.yearTb.TabIndex = 1;
            // 
            // viewStudentsBtn
            // 
            this.viewStudentsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewStudentsBtn.Location = new System.Drawing.Point(419, 134);
            this.viewStudentsBtn.Name = "viewStudentsBtn";
            this.viewStudentsBtn.Size = new System.Drawing.Size(280, 62);
            this.viewStudentsBtn.TabIndex = 2;
            this.viewStudentsBtn.Text = "View List of Students";
            this.viewStudentsBtn.UseVisualStyleBackColor = true;
            this.viewStudentsBtn.Click += new System.EventHandler(this.viewStudentsBtn_Click);
            // 
            // listStudentsView
            // 

            this.listStudentsView.Location = new System.Drawing.Point(355, 202);
            this.listStudentsView.Name = "listStudentsView";
            this.listStudentsView.Size = new System.Drawing.Size(433, 222);
            this.listStudentsView.TabIndex = 3;
            this.listStudentsView.UseCompatibleStateImageBehavior = false;
            this.listStudentsView.GridLines = true;
            this.listStudentsView.View = View.Details;
            this.listStudentsView.Columns.Add("Student ID", 150);
            this.listStudentsView.Columns.Add("Name", 150);
            this.listStudentsView.Columns.Add("Class ID", 150);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listStudentsView);
            this.Controls.Add(this.viewStudentsBtn);
            this.Controls.Add(this.viewDetailBtn);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classIdViewTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classIdTb);
            this.Controls.Add(this.classIdLb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private Label classIdLb;
        private TextBox classIdTb;
        private Button viewDetailBtn;
        private Label label1;
        private TextBox classIdViewTb;
        private Label label2;
        private TextBox classNameTb;
        private Label label3;
        private TextBox yearTb;
        private Button viewStudentsBtn;
        private ListView listStudentsView;
        private ColumnHeader StudentID;
    }
}