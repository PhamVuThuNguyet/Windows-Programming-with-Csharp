namespace UsingDataAdapter
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.studentListDLV = new System.Windows.Forms.DataGridView();
            this.studentInfoGb = new System.Windows.Forms.GroupBox();
            this.classIdTb = new System.Windows.Forms.TextBox();
            this.classIdLb = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.studentIdTb = new System.Windows.Forms.TextBox();
            this.studentIdLb = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDLV)).BeginInit();
            this.studentInfoGb.SuspendLayout();
            this.SuspendLayout();
            this.Load += new System.EventHandler(Form1_Load);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(147, 55);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(184, 78);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load Table Student on DataGrid View";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // studentListDLV
            // 
            this.studentListDLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDLV.Location = new System.Drawing.Point(12, 153);
            this.studentListDLV.Name = "studentListDLV";
            this.studentListDLV.RowHeadersWidth = 51;
            this.studentListDLV.RowTemplate.Height = 29;
            this.studentListDLV.Size = new System.Drawing.Size(431, 201);
            this.studentListDLV.TabIndex = 1;
            this.studentListDLV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListDLV_CellContentClick);
            // 
            // studentInfoGb
            // 
            this.studentInfoGb.Controls.Add(this.classIdTb);
            this.studentInfoGb.Controls.Add(this.classIdLb);
            this.studentInfoGb.Controls.Add(this.nameTb);
            this.studentInfoGb.Controls.Add(this.nameLb);
            this.studentInfoGb.Controls.Add(this.studentIdTb);
            this.studentInfoGb.Controls.Add(this.studentIdLb);
            this.studentInfoGb.Location = new System.Drawing.Point(473, 153);
            this.studentInfoGb.Name = "studentInfoGb";
            this.studentInfoGb.Size = new System.Drawing.Size(315, 143);
            this.studentInfoGb.TabIndex = 2;
            this.studentInfoGb.TabStop = false;
            this.studentInfoGb.Text = "Student Information";
            // 
            // classIdTb
            // 
            this.classIdTb.Location = new System.Drawing.Point(106, 110);
            this.classIdTb.Name = "classIdTb";
            this.classIdTb.Size = new System.Drawing.Size(189, 27);
            this.classIdTb.TabIndex = 1;
            // 
            // classIdLb
            // 
            this.classIdLb.AutoSize = true;
            this.classIdLb.Location = new System.Drawing.Point(6, 117);
            this.classIdLb.Name = "classIdLb";
            this.classIdLb.Size = new System.Drawing.Size(61, 20);
            this.classIdLb.TabIndex = 0;
            this.classIdLb.Text = "Class ID";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(106, 70);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(189, 27);
            this.nameTb.TabIndex = 1;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(6, 77);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(49, 20);
            this.nameLb.TabIndex = 0;
            this.nameLb.Text = "Name";
            // 
            // studentIdTb
            // 
            this.studentIdTb.Location = new System.Drawing.Point(106, 28);
            this.studentIdTb.Name = "studentIdTb";
            this.studentIdTb.Size = new System.Drawing.Size(189, 27);
            this.studentIdTb.TabIndex = 1;
            // 
            // studentIdLb
            // 
            this.studentIdLb.AutoSize = true;
            this.studentIdLb.Location = new System.Drawing.Point(6, 35);
            this.studentIdLb.Name = "studentIdLb";
            this.studentIdLb.Size = new System.Drawing.Size(79, 20);
            this.studentIdLb.TabIndex = 0;
            this.studentIdLb.Text = "Student ID";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(473, 325);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(94, 29);
            this.insertBtn.TabIndex = 3;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(584, 325);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(694, 325);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.studentInfoGb);
            this.Controls.Add(this.studentListDLV);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListDLV)).EndInit();
            this.studentInfoGb.ResumeLayout(false);
            this.studentInfoGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button loadBtn;
        private DataGridView studentListDLV;
        private GroupBox studentInfoGb;
        private TextBox classIdTb;
        private Label classIdLb;
        private TextBox nameTb;
        private Label nameLb;
        private TextBox studentIdTb;
        private Label studentIdLb;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}