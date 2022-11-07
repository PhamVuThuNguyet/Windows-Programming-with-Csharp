using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form4 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        MySqlConnection connection = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySqlConnection(conn);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM class", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            classListBox.ClearSelected();

            while (mySqlDataReader.Read())
            {
                string classId = mySqlDataReader.GetString(0);
                string className = mySqlDataReader.GetString(1);
                string year = mySqlDataReader.GetInt32(2).ToString();

                string line = classId + " - " + className + " - " + year;
                classListBox.Items.Add(line);
            }
            connection.Close();
        }

        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySqlConnection(conn);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            studentListView.Items.Clear();

            if (classListBox.SelectedIndex == -1)
            {
                return;
            }

            string line = classListBox.SelectedItem.ToString();
            string[] strings = line.Split(" - ");
            string classId = strings[0];

            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM student WHERE class_id='{classId}'", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                string studentId = mySqlDataReader.GetString(0);
                string name = mySqlDataReader.GetString(1);
                string classIdRow = mySqlDataReader.GetString(2);

                ListViewItem item = new ListViewItem(studentId);
                item.SubItems.Add(name);
                item.SubItems.Add(classId);

                studentListView.Items.Add(item);
            }
            connection.Close();
        }
    }
}
