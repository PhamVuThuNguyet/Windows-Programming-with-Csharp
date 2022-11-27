
namespace NutriAdvice
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
            this.GetData = new NutriAdvice.Modules.UserInputModule();
            this.DisplayData = new NutriAdvice.Modules.DisplayUserStatusModule();
            this.DisplayResults = new NutriAdvice.Modules.ConsultPrologAndDisplayResultModule();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GetData.Location = new System.Drawing.Point(4, 5);
            this.GetData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GetData.Name = "GetData";
            this.GetData.ReturnBMIStatus = null;
            this.GetData.ReturnUserAge = null;
            this.GetData.ReturnUserBMI = null;
            this.GetData.ReturnUserBMR = null;
            this.GetData.ReturnUserDailyIntake = null;
            this.GetData.ReturnUserDietAction = null;
            this.GetData.ReturnUserDietCalories = null;
            this.GetData.ReturnUserFoodType = null;
            this.GetData.ReturnUserHeight = null;
            this.GetData.ReturnUserSex = null;
            this.GetData.ReturnUserWeight = null;
            this.GetData.Size = new System.Drawing.Size(425, 219);
            this.GetData.TabIndex = 0;
            this.GetData.Load += new System.EventHandler(this.GetData_Load);
            // 
            // DisplayData
            // 
            this.DisplayData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DisplayData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayData.Location = new System.Drawing.Point(4, 229);
            this.DisplayData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(425, 299);
            this.DisplayData.TabIndex = 1;
            // 
            // DisplayResults
            // 
            this.DisplayResults.Location = new System.Drawing.Point(435, 1);
            this.DisplayResults.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.Size = new System.Drawing.Size(316, 528);
            this.DisplayResults.TabIndex = 2;
            this.DisplayResults.UserDietAction = null;
            this.DisplayResults.UserDietIntake = 0D;
            this.DisplayResults.UserFoodType = null;
            this.DisplayResults.Load += new System.EventHandler(this.DisplayResults_Load);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(628, 559);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(106, 26);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TẠI ĐÂY";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nếu đánh giá thể trạng của bạn là suy dinh dưỡng hoặc béo phì, bạn có thể mắc một" +
    " số bệnh khác nữa. Hãy thử hệ thống chẩn đoán thông qua triệu chứng của chúng tô" +
    "i";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(746, 591);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DisplayResults);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nutri Advice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Modules.UserInputModule GetData;
        private Modules.DisplayUserStatusModule DisplayData;
        private Modules.ConsultPrologAndDisplayResultModule DisplayResults;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

