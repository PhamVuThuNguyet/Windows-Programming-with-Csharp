namespace DemoCommonControls
{
    partial class frmEmployeeDetails
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.gpGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDegree = new System.Windows.Forms.Label();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.gpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(237, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(295, 48);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Employee Details";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpID.Location = new System.Drawing.Point(82, 117);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(122, 28);
            this.lbEmpID.TabIndex = 1;
            this.lbEmpID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(273, 118);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(416, 27);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpName.Location = new System.Drawing.Point(82, 172);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(155, 28);
            this.lbEmpName.TabIndex = 1;
            this.lbEmpName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(273, 173);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(416, 27);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(82, 222);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 28);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Phone";
            // 
            // gpGender
            // 
            this.gpGender.AutoSize = true;
            this.gpGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpGender.Controls.Add(this.rdMale);
            this.gpGender.Controls.Add(this.rdFemale);
            this.gpGender.Location = new System.Drawing.Point(273, 274);
            this.gpGender.Name = "gpGender";
            this.gpGender.Size = new System.Drawing.Size(416, 84);
            this.gpGender.TabIndex = 4;
            this.gpGender.TabStop = false;
            this.gpGender.Text = "groupBox1";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdFemale.Location = new System.Drawing.Point(75, 26);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(95, 32);
            this.rdFemale.TabIndex = 0;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdMale.Location = new System.Drawing.Point(223, 26);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(76, 32);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGender.Location = new System.Drawing.Point(82, 302);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(76, 28);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Gender";
            // 
            // lbDegree
            // 
            this.lbDegree.AutoSize = true;
            this.lbDegree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDegree.Location = new System.Drawing.Point(82, 375);
            this.lbDegree.Name = "lbDegree";
            this.lbDegree.Size = new System.Drawing.Size(75, 28);
            this.lbDegree.TabIndex = 1;
            this.lbDegree.Text = "Degree";
            // 
            // cboDegree
            // 
            this.cboDegree.AllowDrop = true;
            this.cboDegree.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Items.AddRange(new object[] {
            "Ph. D.",
            "Master",
            "Engineer",
            "Bachelor",
            "Technician"});
            this.cboDegree.Location = new System.Drawing.Point(273, 381);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(416, 31);
            this.cboDegree.TabIndex = 5;
            this.cboDegree.Text = "---Select Degree---";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(273, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(480, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(273, 225);
            this.mtxtPhone.Mask = "000-0000000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(416, 27);
            this.mtxtPhone.TabIndex = 7;
            // 
            // frmEmployeeDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.gpGender);
            this.Controls.Add(this.lbDegree);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.gpGender.ResumeLayout(false);
            this.gpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbEmpID;
        private TextBox txtEmployeeID;
        private Label lbEmpName;
        private TextBox txtEmployeeName;
        private Label lbPhone;
        private GroupBox gpGender;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Label lbGender;
        private Label lbDegree;
        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;
        private MaskedTextBox mtxtPhone;
    }
}