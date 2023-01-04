using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository CarRepository { get; set; }

        public bool InsertOrUpdate { get; set; } // False : Insert, True : Update

        public Car CarInfo { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) // update mode
            {
                //Show car to perform updating
                textBox1.Text = CarInfo.CarID.ToString();
                textBox2.Text = CarInfo.CarName;
                maskedTextBox1.Text = CarInfo.Price.ToString();
                maskedTextBox2.Text = CarInfo.ReleaseYear.ToString();
                comboBox1.Text = CarInfo.Manufacturer.Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(textBox1.Text),
                    CarName = textBox2.Text,
                    Manufacturer = comboBox1.Text,
                    Price = decimal.Parse(maskedTextBox1.Text),
                    ReleaseYear = int.Parse(maskedTextBox2.Text),
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void button2_Click(object sender, EventArgs e) => Close();



    }
}