namespace MyApp;

partial class frmMain: Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
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
        ToolStripMenuItem menuAbout = new ToolStripMenuItem("&About");
        ToolStripMenuItem menuViewAbout = new ToolStripMenuItem("&View About");
        
        // mainMenu
        mainMenu.Items.AddRange(new ToolStripItem[] {menuFile, menuAbout});
        
        // menuFile
        menuFile.DropDownItems.AddRange(new ToolStripItem[] {menuNew, menuOpen, separator, menuExit});
        
        // menuAbout
        menuAbout.DropDownItems.AddRange(new ToolStripItem[] {menuViewAbout});
        
        // menuNew
        menuNew.ShortcutKeys = (Keys)((Keys.Control | Keys.N));
        
        // menuOpen
        menuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
        
        // menuExit
        menuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
        menuExit.Click += new EventHandler(menuExit_Click);
        
        // menuViewAbout
        menuViewAbout.ShortcutKeys = Keys.F1;
        menuViewAbout.Click += new EventHandler(menuViewDetail_Click);
    }

}