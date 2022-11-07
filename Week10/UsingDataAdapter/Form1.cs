using MySql.Data.MySqlClient;
using System.Data;

namespace UsingDataAdapter
{
    public partial class Form1 : Form
    {
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_management;";
        MySqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;
        int position = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM student", conn);
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataSet = new DataSet();

            // fill data from adapter to dataset
            dataAdapter.Fill(dataSet, "Student");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            studentListDLV.DataSource = dataSet.Tables[0];

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow dataRow = dataSet.Tables[0].NewRow();
            dataRow[0] = studentIdTb.Text;
            dataRow[1] = nameTb.Text;
            dataRow[2] = classIdTb.Text;

            dataSet.Tables[0].Rows.Add(dataRow);

            try
            {
                result = dataAdapter.Update(dataSet, "Student");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (result > 0)
            {
                MessageBox.Show("Insert Successfully");
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No Row Is Sellected");
                return;
            }

            DataRow dataRow = dataSet.Tables[0].Rows[position];
            dataRow.BeginEdit();
            dataRow[0] = studentIdTb.Text;
            dataRow[1] = nameTb.Text;
            dataRow[2] = classIdTb.Text;
            dataRow.EndEdit();

            int result = dataAdapter.Update(dataSet.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (position == -1) return;

            DataRow dataRow = dataSet.Tables[0].Rows[position];
            dataRow.Delete();

            int result = dataAdapter.Update(dataSet.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void studentListDLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;

            DataRow dataRow = dataSet.Tables[0].Rows[position];
            studentIdTb.Text = dataRow[0].ToString();
            nameTb.Text = dataRow[1].ToString();
            classIdTb.Text = dataRow[2].ToString();
        }
    }
}