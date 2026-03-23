namespace InventoryManager;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
		MinimumSize = new Size(400, 220);

		// Initialize the database
		if (Database.Initialize(out string err))
			UpdateStatus("Inventory.db was successfully initialized", Color.Green);
		else
			UpdateStatus("Error! Failed to initialize Inventory.db - " + err, Color.Red);

		RefreshData();

		// Connect button events
		btnAdd.Click += AddPressed;
		btnUpdate.Click += UpdatePressed;
		btnDelete.Click += DeletePressed;
		btnRefresh.Click += RefreshPressed;
		btnExit.Click += ExitPressed;
		dgvInventory.SelectionChanged += SelectionUpdated;
    }


	// BUTTON EVENTS

	void AddPressed(object? sender, EventArgs e)
	{
		// Deselect
		if (dgvInventory.SelectedRows.Count != 0)
			dgvInventory.ClearSelection();

		// Add item
		else
		{
			var input = RetrieveInput();
			if (input is null)
				return;
			
			var (n, c, q, p) = input.Value;
			if (Database.AddProduct(n, c, q, p, out string err))
			{
				UpdateStatus("Item successfully added", Color.Green);
				RefreshData();
			}
			else
				UpdateStatus("Error! Failed to add item - " + err, Color.Red);
		}
	}

	void UpdatePressed(object? sender, EventArgs e)
	{
		var item = GetSelectedItem();
		if (item is null)
		{
			UpdateStatus("Error! No item is selected", Color.Red);
			return;
		}
		else
		{
			// Validate input
			var input = RetrieveInput();
			if (input is null)
				return;

			// Get values to update
			var (i, _, _, _, _) = item.Value;
			var (n, c, q, p) = input.Value;

			if (Database.UpdateProduct(i, n, c, q, p, out string err)) {
				UpdateStatus("Item was successfully updated", Color.Green);
				RefreshData();
				SelectItem(i);
			}
			else
				UpdateStatus("Error! Failed to update item - " + err);
		}
	}

	void DeletePressed(object? sender, EventArgs e)
	{
		var item = GetSelectedItem();
		if (item is null)
		{
			UpdateStatus("Error! No item is selected", Color.Red);
			return;
		}
		else
		{
			if (!PromptConfirmation("Are you sure you wish to delete this item?"))
				return;

			var (i, _, _, _, _) = item.Value;
			if (Database.DeleteProduct(i, out string err)) {
				UpdateStatus("Item was successfully deleted", Color.Green);
				RefreshData();
			}
			else
				UpdateStatus("Error! Failed to delete item - " + err);
		}
	}

	void RefreshPressed(object? sender, EventArgs e)
	{
		RefreshData(true);
	}

	void ExitPressed(object? sender, EventArgs e)
	{
		Close();
	}

	// SELECTION
	void SelectionUpdated(object? sender, EventArgs e)
	{
		var item = GetSelectedItem();
		if (item is null)
		{
			btnAdd.Text = "Add";
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			tbName.Text = "";
			tbCategory.Text = "";
			tbQuantity.Text = "";
			tbPrice.Text = "";

		}
		else
		{
			btnAdd.Text = "Deselect";
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
			var (_, name, category, quantity, price) = item.Value;
			tbName.Text = name;
			tbCategory.Text = category;
			tbQuantity.Text = quantity.ToString();
			tbPrice.Text = price.ToString();

		}
	}

	// Returns a tuple with information for the selected item or null if nothing is selected
	(int id, string name, string category, int quantity, double price)? GetSelectedItem()
	{
		if (dgvInventory.SelectedRows.Count == 0)
		{
			return null;
		}
		else
		{
			var row = dgvInventory.SelectedRows[0];

			int id = Convert.ToInt32(row.Cells[0].Value);
			string name = (string)row.Cells[1].Value!;
			string category = (string)row.Cells[2].Value!;
			int quantity = Convert.ToInt32(row.Cells[3].Value);
			double price = (double)row.Cells[4].Value!;

			return (id, name, category, quantity, price);
		}
	}

	// Selects the item with the ID. Returns false if there is no item with that ID
	bool SelectItem(int itemId)
	{
		foreach (DataGridViewRow row in dgvInventory.Rows)
		{
			var id = row.Cells["Id"].Value;
			if (id != null && Convert.ToInt32(id) == itemId)
			{
				row.Selected = true;
				return true;
			}
		}
		return false;
	}

	// HELPER METHODS

	// Refreshes the data grid view with data from the database
	void RefreshData(bool showStatusSuccess = false)
	{
		var table = Database.GetDataTable(out string err);
		if (table is null)
		{
			dgvInventory.DataSource = null;
			UpdateStatus("Error! Failed to retrieve data from the database - " + err, Color.Red);
		}
		else
		{
			dgvInventory.DataSource = table;
			dgvInventory.ClearSelection();

			// Set column sizes
			double[] SizePercentages = [10, 30, 30, 15, 15];
			for (int i = 0; i < 5; i++) {
				if (dgvInventory.Columns is null || dgvInventory.Columns.Count <= i) break;
				dgvInventory.Columns[i].FillWeight = (float)SizePercentages[i];
			}

			if (showStatusSuccess)
				UpdateStatus("Data successfully refreshed", Color.Green);
		}
	}

	// Updates the status label with a message
	void UpdateStatus(string msg, Color? color = null)
	{
		lblStatus.ForeColor = color ?? Color.Black;
		lblStatus.Text = "Status: " + msg;
	}

	// Validates and returns values from the input text boxes. Returns null if inputs are invalid
	(string name, string category, int quantity, double price)? RetrieveInput()
	{
		string n = tbName.Text;
		string c = tbCategory.Text;
		string q = tbQuantity.Text;
		string p = tbPrice.Text;

		// Validate values

		// Name
		if (string.IsNullOrWhiteSpace(n))
		{
			UpdateStatus("Name cannot be empty", Color.Red);
			return null;
		}
		// Category
		if (string.IsNullOrWhiteSpace(c))
		{
			UpdateStatus("Category cannot be empty", Color.Red);
			return null;
		}
		// Quantity
		if (!int.TryParse(q, out int qInt))
		{
			UpdateStatus("Quantity must be an integer", Color.Red);
			return null;
		}
		else if (qInt < 0)
		{
			UpdateStatus("Quantity must be more than or equal to 0", Color.Red);
			return null;
		}
		// Price
		if (!double.TryParse(p, out double pDouble))
		{
			UpdateStatus("Price must be a number", Color.Red);
			return null;
		}
		else if (pDouble < 0)
		{
			UpdateStatus("Price must be more than or equal to 0", Color.Red);
			return null;
		}

		return (n, c, qInt, pDouble);
	}

	// Asks the user to confirm or cancel, returns their answer
	private static bool PromptConfirmation(string message)
		=> MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK;

}
