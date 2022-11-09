using System;
using System.Windows.Forms;

namespace NutriAdvice.Modules
{
    public partial class UserInputModule : UserControl
    {
        public EventHandler CalculatebtnEvent;
        public int? UserAge
        {
            get
            {
                try
                {
                    return Int32.Parse(Agetxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public double? UserWeight
        {
            get
            {
                try
                {
                    return double.Parse(Weighttxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int? UserHeight
        {
            get
            {
                try
                {
                    return Int32.Parse(Heighttxtbx.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public string UserSex
        {
            get
            {
                try
                {
                    return SelectSexCmbbx.Items[SelectSexCmbbx.SelectedIndex].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        public string UserActiviy
        {
            get
            {
                try
                {
                    return SelectActivityCmbbx.Items[SelectActivityCmbbx.SelectedIndex].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        public string UserFoodType
        {
            get
            {
                try
                {
                    return SelectTypeCmbbx.Items[SelectTypeCmbbx.SelectedIndex].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        public string UserDietAction;

        public Func<int, int> ReturnUserAge { get; set; }
        public Func<string, string> ReturnUserSex { get; set; }
        public Func<double, double> ReturnUserWeight { get; set; }
        public Func<int, int> ReturnUserHeight { get; set; }
        public Func<double, double> ReturnUserBMI { get; set; }
        public Func<string, string> ReturnBMIStatus { get; set; }
        public Func<double, double> ReturnUserBMR { get; set; }
        public Func<double, double> ReturnUserDailyIntake { get; set; }
        public Func<string, string> ReturnUserFoodType { get; set; }
        public Func<string, string> ReturnUserDietAction { get; set; }
        public Func<double, double> ReturnUserDietCalories { get; set; }

        static double BMI(double weight, int height)
        {
            return weight / Math.Pow((height * 0.01), 2);
        }

        static string BMIStatus(double bmi)
        {
            if (bmi < 18.50)
                return "You are below your ideal BMI";
            else if (bmi > 18.50 && bmi < 24.90)
                return "You are in an ideal BMI";
            else if (bmi > 25.00 && bmi < 29.90)
                return "You are overweight";
            else if (bmi > 30.00 && bmi < 34.90)
                return "You are obese";
            else if (bmi > 35.00 && bmi < 40.00)
                return "You are obese II";
            else
                return "You are obese III";
        }

        /*
            Harris-Benedict Equation imperial formula
         */
        static double BMR(double weight, double height, int age, string sex)
        {
            if (sex == "M")
            {
                return ((10 * weight) + (6.25 * height) - (5 * age) + 5);
            }
            else
            {
                return ((10 * weight) + (6.25 * height) - (5 * age) - 161);
            }
        }

        static double DailyCalories(string activity, double bmr)
        {
            if (activity == "Sedentary")
                return (bmr * 1.2);
            else if (activity == "Ligero")
                return (bmr * 1.375);
            else if (activity == "Light")
                return (bmr * 1.55);
            else if (activity == "High")
                return (bmr * 1.725);
            else
                return (bmr * 1.9);
        }

        double DietCalories(string bmistatus, double dailyintake)
        {
            double overweightdiet = (dailyintake - 500);
            if (bmistatus.Contains("You are below your ideal BMI"))
            {
                UserDietAction = "Rise";
                return (dailyintake + 500);
            }
            else if (bmistatus.Contains("You are in an ideal BMI"))
            {
                UserDietAction = "Keep";
                return dailyintake;
            }
            else
            {
                UserDietAction = "Low";
                if (overweightdiet < 1200) return 1300; else return overweightdiet;
            }
        }

        public UserInputModule()
        {
            InitializeComponent();
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            var LocalAge = UserAge ?? 0;
            var LocalWeight = UserWeight ?? 0;
            var LocalHeight = UserHeight ?? 0;
            var LocalSex = UserSex ?? "";
            var LocalActivity = UserActiviy ?? "";
            var LocalFoodType = UserFoodType ?? "";

            var LocalBMI = BMI(LocalWeight, LocalHeight);
            var LocalBMIStatus = BMIStatus(LocalBMI);
            var LocalBMR = BMR(LocalWeight, LocalHeight, LocalAge, LocalSex);
            var LocalDailyIntake = DailyCalories(LocalActivity, LocalBMR);
            var LocalDietCalories = DietCalories(LocalBMIStatus, LocalDailyIntake);

            ReturnUserAge(LocalAge);
            ReturnUserSex(LocalSex);
            ReturnUserWeight(LocalWeight);
            ReturnUserHeight(LocalHeight);
            ReturnUserBMI(LocalBMI);
            ReturnBMIStatus(LocalBMIStatus);
            ReturnUserBMR(LocalBMR);
            ReturnUserDailyIntake(LocalDailyIntake);
            ReturnUserFoodType(LocalFoodType);
            ReturnUserDietAction(UserDietAction);
            ReturnUserDietCalories(LocalDietCalories);

            CalculatebtnEvent(sender, e);
        }
    }
}
