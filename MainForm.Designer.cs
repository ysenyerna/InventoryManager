namespace InventoryManager;

partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        groupManageInventory = new GroupBox();
        tableLayoutPanel2 = new TableLayoutPanel();
        tableLayoutPanel3 = new TableLayoutPanel();
        tbCategory = new TextBox();
        lblName = new Label();
        lblCategory = new Label();
        tbName = new TextBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        tbPrice = new TextBox();
        tbQuantity = new TextBox();
        lblQuantity = new Label();
        lblPrice = new Label();
        tableLayoutPanel5 = new TableLayoutPanel();
        btnExit = new Button();
        btnRefresh = new Button();
        btnDelete = new Button();
        btnUpdate = new Button();
        btnAdd = new Button();
        lblStatus = new Label();
        groupViewInventory = new GroupBox();
        dgvInventory = new DataGridView();
        tableLayoutPanel1.SuspendLayout();
        groupManageInventory.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        groupViewInventory.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(groupManageInventory, 0, 0);
        tableLayoutPanel1.Controls.Add(groupViewInventory, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(570, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // groupManageInventory
        // 
        groupManageInventory.Controls.Add(tableLayoutPanel2);
        groupManageInventory.Dock = DockStyle.Fill;
        groupManageInventory.Location = new Point(3, 3);
        groupManageInventory.Name = "groupManageInventory";
        groupManageInventory.Size = new Size(564, 174);
        groupManageInventory.TabIndex = 0;
        groupManageInventory.TabStop = false;
        groupManageInventory.Text = "Manage Inventory";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
        tableLayoutPanel2.Controls.Add(lblStatus, 0, 3);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 19);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 4;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.Size = new Size(558, 152);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 4;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tbCategory, 3, 0);
        tableLayoutPanel3.Controls.Add(lblName, 0, 0);
        tableLayoutPanel3.Controls.Add(lblCategory, 2, 0);
        tableLayoutPanel3.Controls.Add(tbName, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(552, 32);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // tbCategory
        // 
        tbCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbCategory.Location = new Point(338, 4);
        tbCategory.Name = "tbCategory";
        tbCategory.Size = new Size(211, 23);
        tbCategory.TabIndex = 7;
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblName.AutoSize = true;
        lblName.Location = new Point(3, 8);
        lblName.Name = "lblName";
        lblName.Size = new Size(45, 15);
        lblName.TabIndex = 4;
        lblName.Text = "Name: ";
        // 
        // lblCategory
        // 
        lblCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(271, 8);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(61, 15);
        lblCategory.TabIndex = 5;
        lblCategory.Text = "Category: ";
        // 
        // tbName
        // 
        tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbName.Location = new Point(54, 4);
        tbName.Name = "tbName";
        tbName.Size = new Size(211, 23);
        tbName.TabIndex = 6;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 4;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(tbPrice, 3, 0);
        tableLayoutPanel4.Controls.Add(tbQuantity, 1, 0);
        tableLayoutPanel4.Controls.Add(lblQuantity, 0, 0);
        tableLayoutPanel4.Controls.Add(lblPrice, 2, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 41);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new Size(552, 32);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // tbPrice
        // 
        tbPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbPrice.Location = new Point(334, 4);
        tbPrice.Name = "tbPrice";
        tbPrice.Size = new Size(215, 23);
        tbPrice.TabIndex = 8;
        // 
        // tbQuantity
        // 
        tbQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbQuantity.Location = new Point(68, 4);
        tbQuantity.Name = "tbQuantity";
        tbQuantity.Size = new Size(215, 23);
        tbQuantity.TabIndex = 7;
        // 
        // lblQuantity
        // 
        lblQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new Point(3, 8);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(59, 15);
        lblQuantity.TabIndex = 5;
        lblQuantity.Text = "Quantity: ";
        // 
        // lblPrice
        // 
        lblPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblPrice.AutoSize = true;
        lblPrice.Location = new Point(289, 8);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(39, 15);
        lblPrice.TabIndex = 6;
        lblPrice.Text = "Price: ";
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 5;
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel5.Controls.Add(btnExit, 4, 0);
        tableLayoutPanel5.Controls.Add(btnRefresh, 3, 0);
        tableLayoutPanel5.Controls.Add(btnDelete, 2, 0);
        tableLayoutPanel5.Controls.Add(btnUpdate, 1, 0);
        tableLayoutPanel5.Controls.Add(btnAdd, 0, 0);
        tableLayoutPanel5.Dock = DockStyle.Fill;
        tableLayoutPanel5.Location = new Point(3, 79);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel5.Size = new Size(552, 32);
        tableLayoutPanel5.TabIndex = 2;
        // 
        // btnExit
        // 
        btnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnExit.Location = new Point(443, 4);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(106, 23);
        btnExit.TabIndex = 4;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        // 
        // btnRefresh
        // 
        btnRefresh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnRefresh.Location = new Point(333, 4);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(104, 23);
        btnRefresh.TabIndex = 3;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnDelete.Location = new Point(223, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(104, 23);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnUpdate.Location = new Point(113, 4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(104, 23);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnAdd
        // 
        btnAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnAdd.Location = new Point(3, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(104, 23);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(3, 125);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(552, 15);
        lblStatus.TabIndex = 3;
        lblStatus.Text = "Status: ";
        // 
        // groupViewInventory
        // 
        groupViewInventory.Controls.Add(dgvInventory);
        groupViewInventory.Dock = DockStyle.Fill;
        groupViewInventory.Location = new Point(3, 183);
        groupViewInventory.Name = "groupViewInventory";
        groupViewInventory.Size = new Size(564, 264);
        groupViewInventory.TabIndex = 1;
        groupViewInventory.TabStop = false;
        groupViewInventory.Text = "View Inventory";
        // 
        // dgvInventory
        // 
        dgvInventory.AllowUserToAddRows = false;
        dgvInventory.AllowUserToDeleteRows = false;
        dgvInventory.AllowUserToResizeColumns = false;
        dgvInventory.AllowUserToResizeRows = false;
        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvInventory.Dock = DockStyle.Fill;
        dgvInventory.Location = new Point(3, 19);
        dgvInventory.MultiSelect = false;
        dgvInventory.Name = "dgvInventory";
        dgvInventory.ReadOnly = true;
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvInventory.Size = new Size(558, 242);
        dgvInventory.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 450);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "Inventory Manager";
        tableLayoutPanel1.ResumeLayout(false);
        groupManageInventory.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        groupViewInventory.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private GroupBox groupManageInventory;
    private TableLayoutPanel tableLayoutPanel2;
    private GroupBox groupViewInventory;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private TableLayoutPanel tableLayoutPanel5;
    private Button btnRefresh;
    private Button btnDelete;
    private Button btnUpdate;
    private Button btnAdd;
    private Button btnExit;
    private Label lblStatus;
    private Label lblName;
    private Label lblCategory;
    private TextBox tbCategory;
    private TextBox tbName;
    private TextBox tbPrice;
    private TextBox tbQuantity;
    private Label lblQuantity;
    private Label lblPrice;
    private DataGridView dgvInventory;
}
