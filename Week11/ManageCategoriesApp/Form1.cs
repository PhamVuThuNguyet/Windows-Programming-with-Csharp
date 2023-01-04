namespace ManageCategoriesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            var categories = ManageCategories.Instance.GetCategories();
            tbCategoryID.DataBindings.Clear();
            tbCategoryName.DataBindings.Clear();

            tbCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            tbCategoryName.DataBindings.Add("Text", categories, "CategoryName");

            dgvCategories.DataSource = categories;
        }

        private void Form1_Load(object sender, EventArgs e) => LoadCategories();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = tbCategoryName.Text };
                ManageCategories.Instance.InsertCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryID = int.Parse(tbCategoryID.Text), CategoryName = tbCategoryName.Text };
                ManageCategories.Instance.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryID = int.Parse(tbCategoryID.Text) };
                ManageCategories.Instance.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}