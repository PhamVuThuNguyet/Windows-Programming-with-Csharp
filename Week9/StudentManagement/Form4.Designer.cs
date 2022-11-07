namespace StudentManagement
{
    partial class Form4
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
            this.studentListLb = new System.Windows.Forms.Label();
            this.classListLb = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.classListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentListLb
            // 
            this.studentListLb.AutoSize = true;
            this.studentListLb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentListLb.Location = new System.Drawing.Point(426, 75);
            this.studentListLb.Name = "studentListLb";
            this.studentListLb.Size = new System.Drawing.Size(314, 54);
            this.studentListLb.TabIndex = 0;
            this.studentListLb.Text = "List of Students";
            // 
            // classListLb
            // 
            this.classListLb.AutoSize = true;
            this.classListLb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classListLb.Location = new System.Drawing.Point(45, 75);
            this.classListLb.Name = "classListLb";
            this.classListLb.Size = new System.Drawing.Size(282, 54);
            this.classListLb.TabIndex = 0;
            this.classListLb.Text = "List of Classes";
            // 
            // studentListView
            // 
            this.studentListView.GridLines = true;
            this.studentListView.Location = new System.Drawing.Point(387, 132);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(401, 306);
            this.studentListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.studentListView.TabIndex = 1;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            this.studentListView.Columns.Add("Student ID", 150);
            this.studentListView.Columns.Add("Name", 150);
            this.studentListView.Columns.Add("Class ID", 150);
            // 
            // classListBox
            // 
            this.classListBox.FormattingEnabled = true;
            this.classListBox.ItemHeight = 20;
            this.classListBox.Location = new System.Drawing.Point(12, 132);
            this.classListBox.MultiColumn = true;
            this.classListBox.Name = "classListBox";
            this.classListBox.Size = new System.Drawing.Size(357, 304);
            this.classListBox.Sorted = true;
            this.classListBox.TabIndex = 2;
            this.classListBox.SelectedIndexChanged += new System.EventHandler(this.classListBox_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classListBox);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.classListLb);
            this.Controls.Add(this.studentListLb);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.Form4_Load);

        }

        #endregion

        private Label studentListLb;
        private Label classListLb;
        private ListView studentListView;
        private ListBox classListBox;
    }
}