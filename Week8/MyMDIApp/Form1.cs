namespace MyMDIApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmMain_Load();
        }

        private int counter = 1;

        private void frmMain_Load()
        {
            CreateMyMainMenu();
        }

        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem menuNew = new ToolStripMenuItem("&New");
            ToolStripMenuItem menuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem menuWindow = new ToolStripMenuItem("&Window");
        
            // mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] {menuFile, menuWindow});
            mainMenu.MdiWindowListItem = menuWindow;
        
            // menuFile
            menuFile.DropDownItems.AddRange(new ToolStripItem[] {menuNew, menuOpen, separator, menuExit});
            
            // menuOpen
            menuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            menuOpen.Click += new EventHandler(menuOpen_Click);

            // menuExit
            menuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            menuExit.Click += new EventHandler(menuExit_Click);
            
        }
        
        private void menuOpen_Click(object sender, EventArgs e)
        {
            FrmChildFrom childForm = new FrmChildFrom();
            childForm.Text = $"Child Form {counter++:D2}";
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}