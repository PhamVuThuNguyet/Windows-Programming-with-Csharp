using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ICarRepository carRepository = new CarRepository();
        //Create a data source
        BindingSource source;
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            //Register this event to open the frmCarDetails form that performs updating
            dataGridView1.CellDoubleClick += DgvCarList_CellDoubleClick;
        }
        private void DgvCarList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Update car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //Set focus car update
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
        private void LoadCarList()
        {

            var cars = carRepository.GetCars();
            try
            {
                //
                //
                source = new BindingSource();
                source.DataSource = cars;

                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox4.DataBindings.Clear();
                textBox5.DataBindings.Clear();

                textBox1.DataBindings.Add("Text", source, "CarID");
                textBox2.DataBindings.Add("Text", source, "CarName");
                textBox3.DataBindings.Add("Text", source, "Manufacturer");
                textBox4.DataBindings.Add("Text", source, "Price");
                textBox5.DataBindings.Add("Text", source, "ReleaseYear");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                if (cars.Count() == 0)
                {
                    ClearText();
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }

        }
        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    CarID = int.Parse(textBox1.Text),
                    CarName = textBox2.Text,
                    Manufacturer = textBox3.Text,
                    Price = decimal.Parse(textBox4.Text),
                    ReleaseYear = int.Parse(textBox5.Text)
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return car;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Add car",
                InsertOrUpdate = false,
                CarRepository = carRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                //set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void button4_Click(object sender, EventArgs e) => Close();
        
    }
}
