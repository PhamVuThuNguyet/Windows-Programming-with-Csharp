namespace StudentManagement
{
    partial class Form2
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
            this.ClassIdTb = new System.Windows.Forms.TextBox();
            this.studentNumberLb = new System.Windows.Forms.Label();
            this.studentNumberTb = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classIdLb
            // 
            this.classIdLb.AutoSize = true;
            this.classIdLb.Location = new System.Drawing.Point(136, 99);
            this.classIdLb.Name = "classIdLb";
            this.classIdLb.Size = new System.Drawing.Size(99, 20);
            this.classIdLb.TabIndex = 0;
            this.classIdLb.Text = "Enter Class ID";
            // 
            // ClassIdTb
            // 
            this.ClassIdTb.Location = new System.Drawing.Point(295, 92);
            this.ClassIdTb.Name = "ClassIdTb";
            this.ClassIdTb.Size = new System.Drawing.Size(354, 27);
            this.ClassIdTb.TabIndex = 1;
            // 
            // studentNumberLb
            // 
            this.studentNumberLb.AutoSize = true;
            this.studentNumberLb.Location = new System.Drawing.Point(136, 180);
            this.studentNumberLb.Name = "studentNumberLb";
            this.studentNumberLb.Size = new System.Drawing.Size(142, 20);
            this.studentNumberLb.TabIndex = 0;
            this.studentNumberLb.Text = "Number of Students";
            // 
            // studentNumberTb
            // 
            this.studentNumberTb.Enabled = false;
            this.studentNumberTb.Location = new System.Drawing.Point(295, 173);
            this.studentNumberTb.Name = "studentNumberTb";
            this.studentNumberTb.Size = new System.Drawing.Size(354, 27);
            this.studentNumberTb.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateBtn.Location = new System.Drawing.Point(136, 277);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(513, 113);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate Number of Students";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.studentNumberTb);
            this.Controls.Add(this.studentNumberLb);
            this.Controls.Add(this.ClassIdTb);
            this.Controls.Add(this.classIdLb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label classIdLb;
        private TextBox ClassIdTb;
        private Label studentNumberLb;
        private TextBox studentNumberTb;
        private Button calculateBtn;
    }
}