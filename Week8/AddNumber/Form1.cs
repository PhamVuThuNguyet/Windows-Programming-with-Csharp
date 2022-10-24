namespace AddNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            textBoxResult.Text = (num1 + num2).ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}