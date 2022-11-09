using System;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{
    public partial class DisplayUserStatusModule : UserControl
    {
        public int UserAge
        {
            set
            {
                DisplayAge2.Text = value.ToString();
            }
        }

        public string UserSex
        {
            set
            {
                DisplaySex.Text = value.ToString();
            }
        }

        public double UserWeight
        {
            set
            {
                DisplayWeight2.Text = value.ToString();
            }
        }

        public int UserHeight
        {
            set
            {
                DisplayHeight.Text = value.ToString();
            }
        }

        public double UserBMI
        {
            set
            {
                DisplayBmi.Text = Math.Round(value, 2).ToString("N2");
            }
        }

        public string UserBMIStatus
        {
            set
            {
                DisplayBMIStatus.Text = value.ToString();
            }
        }

        public double UserBMR
        {
            set
            {
                DisplayBmr.Text = value.ToString();
            }
        }

        public double UserDailyIntake
        {
            set
            {
                DisplayDailyIntake.Text = Math.Round(value, 2).ToString("N2");
            }
        }

        public double UserDietIntake
        {
            set
            {
                DisplayDietIntake.Text = Math.Round(value, 2).ToString("N2");
            }
        }

        public string UserDietAction
        {
            set
            {
                DisplayUserAction.Text = value.ToString();
            }
        }

        public string UserFoodType
        {
            set
            {
                DisplayRecipeType.Text = value.ToString();
            }
        }

        public DisplayUserStatusModule()
        {
            InitializeComponent();
        }

        private void DisplayDailyIntake_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDietIntake_Click(object sender, EventArgs e)
        {

        }

        private void DisplayUserAction_Click(object sender, EventArgs e)
        {

        }

        private void DisplayRecipeType_Click(object sender, EventArgs e)
        {

        }
    }
}
