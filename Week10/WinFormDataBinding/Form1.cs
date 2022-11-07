using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormDataBinding
{
    public partial class Form1 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        DataSet dataSet = null;
        MySqlDataAdapter dataAdapter = null;
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                str = "SELECT * FROM class";
                dataAdapter = new MySqlDataAdapter(str, conn);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Class");

                classIdCb.DataSource = dataSet.Tables[0];
                classIdCb.ValueMember = "class_id";
                classIdCb.DisplayMember = "class_id";

                classNameCb.DataSource = dataSet.Tables[0];
                classNameCb.ValueMember = "class_name";
                classNameCb.DisplayMember = "class_name";

                yearTxt.DataBindings.Add("Text", dataSet.Tables[0], "year");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            str = $"SELECT * FROM student WHERE class_id='{classIdCb.Text}'";
            dataAdapter = new MySqlDataAdapter(str, conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Student");
            studentListDgv.DataSource = dataSet.Tables[0];    
        }
    }
}