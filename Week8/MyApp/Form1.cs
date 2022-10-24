namespace MyApp;

public partial class frmMain: Form
{
    public frmMain()
    {
        frmMain_Load();
    }
    private void frmMain_Load()
    {
        CreateMyMainMenu();
    }
    private void menuViewDetail_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Welcome to Windows Forms Application with .NET", "About");
    }

    private void menuExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}