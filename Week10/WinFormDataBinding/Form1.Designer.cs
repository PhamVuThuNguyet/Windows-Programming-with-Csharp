namespace WinFormDataBinding
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
            this.components = new System.ComponentModel.Container();
            this.classIdLb = new System.Windows.Forms.Label();
            this.classIdCb = new System.Windows.Forms.ComboBox();
            this.classNameLb = new System.Windows.Forms.Label();
            this.classNameCb = new System.Windows.Forms.ComboBox();
            this.yearLb = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentListDgv = new System.Windows.Forms.DataGridView();
            this.yearTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // classIdLb
            // 
            this.classIdLb.AutoSize = true;
            this.classIdLb.Location = new System.Drawing.Point(32, 45);
            this.classIdLb.Name = "classIdLb";
            this.classIdLb.Size = new System.Drawing.Size(61, 20);
            this.classIdLb.TabIndex = 0;
            this.classIdLb.Text = "Class ID";
            // 
            // classIdCb
            // 
            this.classIdCb.FormattingEnabled = true;
            this.classIdCb.Location = new System.Drawing.Point(127, 42);
            this.classIdCb.Name = "classIdCb";
            this.classIdCb.Size = new System.Drawing.Size(151, 28);
            this.classIdCb.TabIndex = 1;
            // 
            // classNameLb
            // 
            this.classNameLb.AutoSize = true;
            this.classNameLb.Location = new System.Drawing.Point(32, 92);
            this.classNameLb.Name = "classNameLb";
            this.classNameLb.Size = new System.Drawing.Size(86, 20);
            this.classNameLb.TabIndex = 0;
            this.classNameLb.Text = "Class Name";
            // 
            // classNameCb
            // 
            this.classNameCb.FormattingEnabled = true;
            this.classNameCb.Location = new System.Drawing.Point(127, 89);
            this.classNameCb.Name = "classNameCb";
            this.classNameCb.Size = new System.Drawing.Size(151, 28);
            this.classNameCb.TabIndex = 1;
            // 
            // yearLb
            // 
            this.yearLb.AutoSize = true;
            this.yearLb.Location = new System.Drawing.Point(32, 138);
            this.yearLb.Name = "yearLb";
            this.yearLb.Size = new System.Drawing.Size(37, 20);
            this.yearLb.TabIndex = 0;
            this.yearLb.Text = "Year";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.Location = new System.Drawing.Point(468, 64);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(141, 64);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "VIEW";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WinFormDataBinding.Form1);
            // 
            // studentListDgv
            // 
            this.studentListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDgv.Location = new System.Drawing.Point(32, 189);
            this.studentListDgv.Name = "studentListDgv";
            this.studentListDgv.RowHeadersWidth = 51;
            this.studentListDgv.RowTemplate.Height = 29;
            this.studentListDgv.Size = new System.Drawing.Size(756, 235);
            this.studentListDgv.TabIndex = 3;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(127, 143);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(151, 27);
            this.yearTxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.studentListDgv);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.classNameCb);
            this.Controls.Add(this.classIdCb);
            this.Controls.Add(this.yearLb);
            this.Controls.Add(this.classNameLb);
            this.Controls.Add(this.classIdLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label classIdLb;
        private ComboBox classIdCb;
        private Label classNameLb;
        private ComboBox classNameCb;
        private Label yearLb;
        private Button viewBtn;
        private BindingSource form1BindingSource;
        private DataGridView studentListDgv;
        private TextBox yearTxt;
    }
}