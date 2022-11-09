using NutriAdvice.Modules;
using System;
using System.Windows.Forms;

namespace NutriAdvice
{
    public partial class Form1 : Form
    {
        public UserInputModule UserInputModule { get; set; }
        public DisplayUserStatusModule DisplayUserStatusModule { get; set; }
        public ConsultPrologAndDisplayResultModule ConsultPrologAndDisplayResultModule { get; set; }

        public Form1()
        {
            InitializeComponent();

            UserInputModule = GetData;
            DisplayUserStatusModule = DisplayData;
            ConsultPrologAndDisplayResultModule = DisplayResults;

            UserInputModule.ReturnUserAge += (age) =>
            {
                DisplayUserStatusModule.UserAge = age;
                return age;
            };

            UserInputModule.ReturnUserSex += (sex) =>
            {
                DisplayUserStatusModule.UserSex = sex;
                return sex;
            };

            UserInputModule.ReturnUserWeight += (weight) =>
            {
                DisplayUserStatusModule.UserWeight = weight;
                return weight;
            };

            UserInputModule.ReturnUserHeight += (height) =>
            {
                DisplayUserStatusModule.UserHeight = height;
                return height;
            };

            UserInputModule.ReturnUserBMI += (bmi) =>
            {
                DisplayUserStatusModule.UserBMI = bmi;
                return bmi;
            };

            UserInputModule.ReturnBMIStatus += (bmistatus) =>
            {
                DisplayUserStatusModule.UserBMIStatus = bmistatus;
                return bmistatus;
            };

            UserInputModule.ReturnUserBMR += (bmr) =>
            {
                DisplayUserStatusModule.UserBMR = bmr;
                return bmr;
            };

            UserInputModule.ReturnUserDailyIntake += (dailyintake) =>
            {
                DisplayUserStatusModule.UserDailyIntake = dailyintake;
                return dailyintake;
            };

            // values for Prolog
            UserInputModule.ReturnUserDietCalories += (dietintake) =>
            {
                DisplayUserStatusModule.UserDietIntake = dietintake;
                ConsultPrologAndDisplayResultModule.UserDietIntake = dietintake;
                return dietintake;
            };

            UserInputModule.ReturnUserDietAction += (action) =>
            {
                DisplayUserStatusModule.UserDietAction = action;
                ConsultPrologAndDisplayResultModule.UserDietAction = action;
                return action;
            };

            UserInputModule.ReturnUserFoodType += (type) =>
            {
                DisplayUserStatusModule.UserFoodType = type;
                ConsultPrologAndDisplayResultModule.UserFoodType = type;
                return type;
            };

            // Call for Prolog consulting
            UserInputModule.CalculatebtnEvent += new EventHandler(CalculatebtnClicked);
        }

        protected void CalculatebtnClicked(object sender, EventArgs e)
        {
            ConsultPrologAndDisplayResultModule.ConsultProlog();
        }

        private void GetData_Load(object sender, EventArgs e)
        {

        }

        private void DisplayResults_Load(object sender, EventArgs e)
        {

        }
    }
}
