using MySql.Data.MySqlClient;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        MySqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(conn);

                // Open the database
                connection.Open();

                MessageBox.Show("Connect Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Disconnect Successfully");
            }
        }
    }
}