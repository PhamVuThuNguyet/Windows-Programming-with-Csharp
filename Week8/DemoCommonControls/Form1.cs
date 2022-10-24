using System.Text;

namespace DemoCommonControls
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtEmployeeID.Text;
            string EmployeeName = txtEmployeeName.Text;

            string Phone = mtxtPhone.Text;
            string Gender = (rdFemale.Checked ? "Female" : "Male");
            string Degree = cboDegree.Text;

            StringBuilder builder = new StringBuilder();
            builder.Append($"Employee ID: {EmployeeID}");
            builder.Append($"Employee Name: {EmployeeName}");
            builder.Append($"Phone: {Phone}");
            builder.Append($"Gender: {Gender}");
            builder.Append($"Degree: {Degree}");

            MessageBox.Show(builder.ToString(), "Employee Details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}