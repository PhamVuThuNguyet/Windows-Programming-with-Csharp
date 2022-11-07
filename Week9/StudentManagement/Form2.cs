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
    public partial class Form2 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        MySqlConnection connection = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySqlConnection(conn);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT COUNT(*) FROM student WHERE class_id ='{ClassIdTb.Text}'", connection);

            int result = (int)(long)mySqlCommand.ExecuteScalar();
            studentNumberTb.Text = result.ToString();
            connection.Close();
        }
    }
}
