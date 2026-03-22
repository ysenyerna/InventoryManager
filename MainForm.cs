
namespace InventoryManager;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
		MinimumSize = new Size(400, 220);

		// Initialize the database
		if (Database.Initialize(out string error))
			UpdateStatus("Inventory.db was successfully initialized", Color.Green);
		else
			UpdateStatus("Error! Failed to initialize Inventory.db - " + error, Color.Red);


		
		
    }



	void UpdateStatus(string msg, Color? color = null)
	{
		lblStatus.ForeColor = color ?? Color.Black;
		lblStatus.Text = "Status: " + msg;
	}
}
