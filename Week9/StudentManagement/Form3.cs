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
    public partial class Form3 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        MySqlConnection connection = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void viewDetailBtn_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySqlConnection(conn);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM class WHERE class_id='{classIdTb.Text}'", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                classIdViewTb.Text = mySqlDataReader.GetString(0);
                classNameTb.Text = mySqlDataReader.GetString(1);
                yearTb.Text = mySqlDataReader.GetInt32(2).ToString();
            }

            connection.Close();
        }

        private void viewStudentsBtn_Click(object sender, EventArgs e)
        {

            if (connection == null)
            {
                connection = new MySqlConnection(conn);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            listStudentsView.Items.Clear();
            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM student WHERE class_id='{classIdTb.Text}'", connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                string studentId = mySqlDataReader.GetString(0);
                string name = mySqlDataReader.GetString(1);
                string classId = mySqlDataReader.GetString(2);

                ListViewItem item = new ListViewItem(studentId);
                item.SubItems.Add(name);
                item.SubItems.Add(classId);

                listStudentsView.Items.Add(item);
            }

            connection.Close();
        }
    }
}
