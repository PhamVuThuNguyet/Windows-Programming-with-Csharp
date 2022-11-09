
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetData = new NutriAdvice.Modules.UserInputModule();
            this.DisplayData = new NutriAdvice.Modules.DisplayUserStatusModule();
            this.DisplayResults = new NutriAdvice.Modules.ConsultPrologAndDisplayResultModule();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.GetData.Location = new System.Drawing.Point(12, 50);
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
            this.GetData.Size = new System.Drawing.Size(429, 233);
            this.GetData.TabIndex = 0;
            this.GetData.Load += new System.EventHandler(this.GetData_Load);
            // 
            // DisplayData
            // 
            this.DisplayData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(46)))));
            this.DisplayData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayData.Location = new System.Drawing.Point(12, 305);
            this.DisplayData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(428, 299);
            this.DisplayData.TabIndex = 1;
            // 
            // DisplayResults
            // 
            this.DisplayResults.Location = new System.Drawing.Point(448, 38);
            this.DisplayResults.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DisplayResults.Name = "DisplayResults";
            this.DisplayResults.Size = new System.Drawing.Size(371, 567);
            this.DisplayResults.TabIndex = 2;
            this.DisplayResults.UserDietAction = null;
            this.DisplayResults.UserDietIntake = 0D;
            this.DisplayResults.UserFoodType = null;
            this.DisplayResults.Load += new System.EventHandler(this.DisplayResults_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(839, 815);
            this.Controls.Add(this.DisplayResults);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.GetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Nutri Advice";
            this.ResumeLayout(false);

        }

        #endregion

        private Modules.UserInputModule GetData;
        private Modules.DisplayUserStatusModule DisplayData;
        private Modules.ConsultPrologAndDisplayResultModule DisplayResults;
    }
}

