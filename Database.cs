using System.Data;
using System.Data.SQLite;

// Class for interacting with the database
static class Database
{
	private const string ConnectionString = "Data Source=Inventory.db";



	// Initializes the database
	public static bool Initialize(out string errorMsg)
	{
		errorMsg = "";
		try
		{
			using var conn = new SQLiteConnection(ConnectionString);
			conn.Open();

			var cmd = conn.CreateCommand();
			cmd.CommandText = "CREATE TABLE IF NOT EXISTS Products ( " +
			"Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
			"Name TEXT NOT NULL, Category TEXT NOT NULL, " +
			"Quantity INTEGER NOT NULL CHECK(Quantity >= 0), "+ 
			"Price REAL NOT NULL CHECK(Price >= 0));";
			cmd.ExecuteNonQuery();
			return true;
		}
		catch (Exception e)
		{
			errorMsg = e.Message;
			return false;
		}
	}


	// Attempts to add an item to the database
	public static bool AddProduct(string name, string category, int quantity, double price, out string errorMsg)
	{
		errorMsg = "";

		try
		{
			using var conn = new SQLiteConnection(ConnectionString);
			conn.Open();
		
			string sql = "INSERT INTO Products (Name, Category, Quantity, Price) "+
			"VALUES (@n, @c, @q, @p)";
			using var cmd = new SQLiteCommand(sql, conn);
			cmd.Parameters.AddWithValue("@n", name);
			cmd.Parameters.AddWithValue("@c", category);
			cmd.Parameters.AddWithValue("@q", quantity);
			cmd.Parameters.AddWithValue("@p", price);

			cmd.ExecuteNonQuery();
			return true;
		}
		catch (Exception e)
		{
			errorMsg = e.Message;
			return false;
		}
	}

	// Attempts to update an item in the database
	public static bool UpdateProduct(int id, string newName, string newCategory, int newQuantity, double newPrice, out string errorMsg)
	{
		errorMsg = "";

		try
		{
			using var conn = new SQLiteConnection(ConnectionString);
			conn.Open();
		
			string sql = "UPDATE Products " +
			"SET Name = @n, Category = @c, Quantity = @q, Price = @p " +
			"WHERE Id = @i";
			using var cmd = new SQLiteCommand(sql, conn);
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@n", newName);
			cmd.Parameters.AddWithValue("@c", newCategory);
			cmd.Parameters.AddWithValue("@q", newQuantity);
			cmd.Parameters.AddWithValue("@p", newPrice);

			int rows = cmd.ExecuteNonQuery();
			if (rows == 0)
			{
				errorMsg = "No product found to update";
				return false;
			}

			return true;
		}
		catch (Exception e)
		{
			errorMsg = e.Message;
			return false;
		}
	}

	// Attempts to remove an item from the database
	public static bool DeleteProduct(int id, out string errorMsg)
	{
		errorMsg = "";

		try
		{
			using var conn = new SQLiteConnection(ConnectionString);
			conn.Open();
		
			string sql = "DELETE FROM Products WHERE Id = @i";
			using var cmd = new SQLiteCommand(sql, conn);
			cmd.Parameters.AddWithValue("@i", id);

			int rows = cmd.ExecuteNonQuery();
			if (rows == 0)
			{
				errorMsg = "No product found to delete";
				return false;
			}

			return true;
		}
		catch (Exception e)
		{
			errorMsg = e.Message;
			return false;
		}
	}

	// Attempts to return a table with information from the database
	public static DataTable? GetDataTable(out string errorMsg)
	{
		errorMsg = "";

		try
		{
			using var conn = new SQLiteConnection(ConnectionString);
			conn.Open();

			string sql = "SELECT * FROM Products";
			using var adapter = new SQLiteDataAdapter(sql, conn);
			var table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		catch (Exception e)
		{
			errorMsg = e.Message;
			return null;
		}
	}

}