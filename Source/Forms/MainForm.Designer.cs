namespace POS.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TransactionGridView = new System.Windows.Forms.DataGridView();
			this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FunctionsPanel = new System.Windows.Forms.Panel();
			this.RandomButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.SidePanel = new System.Windows.Forms.Panel();
			this.TransactionFunctionsPanel = new System.Windows.Forms.Panel();
			this.ItemSearchButton = new System.Windows.Forms.Button();
			this.VoidItemButton = new System.Windows.Forms.Button();
			this.VoidLineButton = new System.Windows.Forms.Button();
			this.VoidTransactionButton = new System.Windows.Forms.Button();
			this.NumbersPanel = new System.Windows.Forms.Panel();
			this.NumberInputBackgroundPanel = new System.Windows.Forms.Panel();
			this.NumberInputBox = new System.Windows.Forms.TextBox();
			this.NumberButton00 = new System.Windows.Forms.Button();
			this.NumberButtonOK = new System.Windows.Forms.Button();
			this.NumberButtonDelete = new System.Windows.Forms.Button();
			this.NumberButtonQuantity = new System.Windows.Forms.Button();
			this.NumberButton9 = new System.Windows.Forms.Button();
			this.NumberButton8 = new System.Windows.Forms.Button();
			this.NumberButton7 = new System.Windows.Forms.Button();
			this.NumberButton6 = new System.Windows.Forms.Button();
			this.NumberButton5 = new System.Windows.Forms.Button();
			this.NumberButton4 = new System.Windows.Forms.Button();
			this.NumberButton3 = new System.Windows.Forms.Button();
			this.NumberButton2 = new System.Windows.Forms.Button();
			this.NumberButton1 = new System.Windows.Forms.Button();
			this.NumberButtonPeriod = new System.Windows.Forms.Button();
			this.NumberButton0 = new System.Windows.Forms.Button();
			this.MainTabber = new System.Windows.Forms.TabControl();
			this.TransactionPage = new System.Windows.Forms.TabPage();
			this.ItemsSelectionPage = new System.Windows.Forms.TabPage();
			this.ItemSelectionPanel = new System.Windows.Forms.Panel();
			this.ItemSearchListView = new System.Windows.Forms.ListView();
			this.SearchResultsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SearchResultsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SearchResultsPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ItemSearchInputBoxPanel = new System.Windows.Forms.Panel();
			this.ItemSearchInputBox = new System.Windows.Forms.TextBox();
			this.ItemSearchAddButton = new System.Windows.Forms.Button();
			this.ItemSearchHeading = new System.Windows.Forms.Label();
			this.PaymentPage = new System.Windows.Forms.TabPage();
			this.PaymentPanel = new System.Windows.Forms.Panel();
			this.PaymentCancelButton = new System.Windows.Forms.Button();
			this.PaymentCardLabel = new System.Windows.Forms.Label();
			this.PaymentCashLabel = new System.Windows.Forms.Label();
			this.PaymentMethodHeader = new System.Windows.Forms.Label();
			this.TransactionFooterPanel = new System.Windows.Forms.Panel();
			this.TotalPriceLabel = new System.Windows.Forms.Label();
			this.TotalLabel = new System.Windows.Forms.Label();
			this.ItemWatcher = new System.IO.FileSystemWatcher();
			this.CashPaymentPage = new System.Windows.Forms.TabPage();
			this.CashPaymentPanel = new System.Windows.Forms.Panel();
			this.PaymentCardButton = new System.Windows.Forms.Button();
			this.PaymentCashButton = new System.Windows.Forms.Button();
			this.CashPaymentHeader = new System.Windows.Forms.Label();
			this.CashPaymentParagraph = new System.Windows.Forms.Label();
			this.ChangePage = new System.Windows.Forms.TabPage();
			this.ChangePanel = new System.Windows.Forms.Panel();
			this.ChangePageHeader = new System.Windows.Forms.Label();
			this.ChangeDisplayPanel = new System.Windows.Forms.Panel();
			this.ChangeLabelHeader = new System.Windows.Forms.Label();
			this.ChangeLabel = new System.Windows.Forms.Label();
			this.DrawerReminderLabel = new System.Windows.Forms.Label();
			this.ChangeDisplayTimer = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TransactionGridView)).BeginInit();
			this.FunctionsPanel.SuspendLayout();
			this.SidePanel.SuspendLayout();
			this.TransactionFunctionsPanel.SuspendLayout();
			this.NumbersPanel.SuspendLayout();
			this.NumberInputBackgroundPanel.SuspendLayout();
			this.MainTabber.SuspendLayout();
			this.TransactionPage.SuspendLayout();
			this.ItemsSelectionPage.SuspendLayout();
			this.ItemSelectionPanel.SuspendLayout();
			this.ItemSearchInputBoxPanel.SuspendLayout();
			this.PaymentPage.SuspendLayout();
			this.PaymentPanel.SuspendLayout();
			this.TransactionFooterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemWatcher)).BeginInit();
			this.CashPaymentPage.SuspendLayout();
			this.CashPaymentPanel.SuspendLayout();
			this.ChangePage.SuspendLayout();
			this.ChangePanel.SuspendLayout();
			this.ChangeDisplayPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TransactionGridView
			// 
			this.TransactionGridView.AllowUserToAddRows = false;
			this.TransactionGridView.AllowUserToDeleteRows = false;
			this.TransactionGridView.AllowUserToResizeColumns = false;
			this.TransactionGridView.AllowUserToResizeRows = false;
			this.TransactionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TransactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TransactionGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.TransactionGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TransactionGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.TransactionGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.TransactionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.TransactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TransactionGridView.ColumnHeadersVisible = false;
			this.TransactionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameColumn,
            this.ItemQuantityColumn,
            this.ItemPriceColumn});
			this.TransactionGridView.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TransactionGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.TransactionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.TransactionGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
			this.TransactionGridView.Location = new System.Drawing.Point(6, 6);
			this.TransactionGridView.MultiSelect = false;
			this.TransactionGridView.Name = "TransactionGridView";
			this.TransactionGridView.ReadOnly = true;
			this.TransactionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.TransactionGridView.RowHeadersVisible = false;
			this.TransactionGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TransactionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TransactionGridView.ShowCellErrors = false;
			this.TransactionGridView.ShowCellToolTips = false;
			this.TransactionGridView.ShowEditingIcon = false;
			this.TransactionGridView.ShowRowErrors = false;
			this.TransactionGridView.Size = new System.Drawing.Size(419, 391);
			this.TransactionGridView.TabIndex = 0;
			// 
			// ItemNameColumn
			// 
			this.ItemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ItemNameColumn.FillWeight = 78.95552F;
			this.ItemNameColumn.HeaderText = "Name";
			this.ItemNameColumn.MaxInputLength = 128;
			this.ItemNameColumn.Name = "ItemNameColumn";
			this.ItemNameColumn.ReadOnly = true;
			this.ItemNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemNameColumn.Width = 270;
			// 
			// ItemQuantityColumn
			// 
			this.ItemQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ItemQuantityColumn.FillWeight = 23.65569F;
			this.ItemQuantityColumn.HeaderText = "Quantity";
			this.ItemQuantityColumn.MaxInputLength = 8;
			this.ItemQuantityColumn.Name = "ItemQuantityColumn";
			this.ItemQuantityColumn.ReadOnly = true;
			this.ItemQuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemQuantityColumn.Width = 75;
			// 
			// ItemPriceColumn
			// 
			this.ItemPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ItemPriceColumn.FillWeight = 200F;
			this.ItemPriceColumn.HeaderText = "Price";
			this.ItemPriceColumn.MaxInputLength = 64;
			this.ItemPriceColumn.Name = "ItemPriceColumn";
			this.ItemPriceColumn.ReadOnly = true;
			this.ItemPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemPriceColumn.Width = 70;
			// 
			// FunctionsPanel
			// 
			this.FunctionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FunctionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
			this.FunctionsPanel.Controls.Add(this.button3);
			this.FunctionsPanel.Controls.Add(this.button2);
			this.FunctionsPanel.Controls.Add(this.button1);
			this.FunctionsPanel.Controls.Add(this.RandomButton);
			this.FunctionsPanel.Controls.Add(this.LogoutButton);
			this.FunctionsPanel.Location = new System.Drawing.Point(12, 493);
			this.FunctionsPanel.Name = "FunctionsPanel";
			this.FunctionsPanel.Size = new System.Drawing.Size(760, 69);
			this.FunctionsPanel.TabIndex = 1;
			// 
			// RandomButton
			// 
			this.RandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.RandomButton.Enabled = false;
			this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RandomButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RandomButton.Location = new System.Drawing.Point(520, 15);
			this.RandomButton.Name = "RandomButton";
			this.RandomButton.Size = new System.Drawing.Size(110, 42);
			this.RandomButton.TabIndex = 1;
			this.RandomButton.Text = "Add Random";
			this.RandomButton.UseVisualStyleBackColor = false;
			this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
			// 
			// LogoutButton
			// 
			this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogoutButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogoutButton.Location = new System.Drawing.Point(636, 15);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(110, 42);
			this.LogoutButton.TabIndex = 0;
			this.LogoutButton.Text = "Log Out";
			this.LogoutButton.UseVisualStyleBackColor = false;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// SidePanel
			// 
			this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
			this.SidePanel.Controls.Add(this.TransactionFunctionsPanel);
			this.SidePanel.Controls.Add(this.NumbersPanel);
			this.SidePanel.Location = new System.Drawing.Point(458, 12);
			this.SidePanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.SidePanel.Name = "SidePanel";
			this.SidePanel.Size = new System.Drawing.Size(314, 475);
			this.SidePanel.TabIndex = 2;
			// 
			// TransactionFunctionsPanel
			// 
			this.TransactionFunctionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.TransactionFunctionsPanel.Controls.Add(this.ItemSearchButton);
			this.TransactionFunctionsPanel.Controls.Add(this.VoidItemButton);
			this.TransactionFunctionsPanel.Controls.Add(this.VoidLineButton);
			this.TransactionFunctionsPanel.Controls.Add(this.VoidTransactionButton);
			this.TransactionFunctionsPanel.Location = new System.Drawing.Point(47, 11);
			this.TransactionFunctionsPanel.Name = "TransactionFunctionsPanel";
			this.TransactionFunctionsPanel.Size = new System.Drawing.Size(226, 163);
			this.TransactionFunctionsPanel.TabIndex = 6;
			// 
			// ItemSearchButton
			// 
			this.ItemSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
			this.ItemSearchButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemSearchButton.Location = new System.Drawing.Point(13, 122);
			this.ItemSearchButton.Name = "ItemSearchButton";
			this.ItemSearchButton.Size = new System.Drawing.Size(200, 32);
			this.ItemSearchButton.TabIndex = 5;
			this.ItemSearchButton.Text = "Item Search →";
			this.ItemSearchButton.UseVisualStyleBackColor = false;
			this.ItemSearchButton.Click += new System.EventHandler(this.ItemSearchButton_Click);
			// 
			// VoidItemButton
			// 
			this.VoidItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.VoidItemButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VoidItemButton.Location = new System.Drawing.Point(13, 8);
			this.VoidItemButton.Name = "VoidItemButton";
			this.VoidItemButton.Size = new System.Drawing.Size(200, 32);
			this.VoidItemButton.TabIndex = 2;
			this.VoidItemButton.Text = "Void Item";
			this.VoidItemButton.UseVisualStyleBackColor = false;
			this.VoidItemButton.Click += new System.EventHandler(this.VoidItemButton_Click);
			// 
			// VoidLineButton
			// 
			this.VoidLineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.VoidLineButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VoidLineButton.Location = new System.Drawing.Point(13, 46);
			this.VoidLineButton.Name = "VoidLineButton";
			this.VoidLineButton.Size = new System.Drawing.Size(200, 32);
			this.VoidLineButton.TabIndex = 3;
			this.VoidLineButton.Text = "Void Line";
			this.VoidLineButton.UseVisualStyleBackColor = false;
			this.VoidLineButton.Click += new System.EventHandler(this.VoidLineButton_Click);
			// 
			// VoidTransactionButton
			// 
			this.VoidTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.VoidTransactionButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VoidTransactionButton.Location = new System.Drawing.Point(13, 84);
			this.VoidTransactionButton.Name = "VoidTransactionButton";
			this.VoidTransactionButton.Size = new System.Drawing.Size(200, 32);
			this.VoidTransactionButton.TabIndex = 4;
			this.VoidTransactionButton.Text = "Void Transaction";
			this.VoidTransactionButton.UseVisualStyleBackColor = false;
			this.VoidTransactionButton.Click += new System.EventHandler(this.VoidTransactionButton_Click);
			// 
			// NumbersPanel
			// 
			this.NumbersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.NumbersPanel.Controls.Add(this.NumberInputBackgroundPanel);
			this.NumbersPanel.Controls.Add(this.NumberButton00);
			this.NumbersPanel.Controls.Add(this.NumberButtonOK);
			this.NumbersPanel.Controls.Add(this.NumberButtonDelete);
			this.NumbersPanel.Controls.Add(this.NumberButtonQuantity);
			this.NumbersPanel.Controls.Add(this.NumberButton9);
			this.NumbersPanel.Controls.Add(this.NumberButton8);
			this.NumbersPanel.Controls.Add(this.NumberButton7);
			this.NumbersPanel.Controls.Add(this.NumberButton6);
			this.NumbersPanel.Controls.Add(this.NumberButton5);
			this.NumbersPanel.Controls.Add(this.NumberButton4);
			this.NumbersPanel.Controls.Add(this.NumberButton3);
			this.NumbersPanel.Controls.Add(this.NumberButton2);
			this.NumbersPanel.Controls.Add(this.NumberButton1);
			this.NumbersPanel.Controls.Add(this.NumberButtonPeriod);
			this.NumbersPanel.Controls.Add(this.NumberButton0);
			this.NumbersPanel.Location = new System.Drawing.Point(47, 180);
			this.NumbersPanel.Name = "NumbersPanel";
			this.NumbersPanel.Padding = new System.Windows.Forms.Padding(10);
			this.NumbersPanel.Size = new System.Drawing.Size(226, 281);
			this.NumbersPanel.TabIndex = 5;
			// 
			// NumberInputBackgroundPanel
			// 
			this.NumberInputBackgroundPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NumberInputBackgroundPanel.Controls.Add(this.NumberInputBox);
			this.NumberInputBackgroundPanel.Location = new System.Drawing.Point(13, 13);
			this.NumberInputBackgroundPanel.Name = "NumberInputBackgroundPanel";
			this.NumberInputBackgroundPanel.Size = new System.Drawing.Size(200, 37);
			this.NumberInputBackgroundPanel.TabIndex = 19;
			// 
			// NumberInputBox
			// 
			this.NumberInputBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NumberInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NumberInputBox.Location = new System.Drawing.Point(3, 9);
			this.NumberInputBox.MaxLength = 24;
			this.NumberInputBox.Name = "NumberInputBox";
			this.NumberInputBox.ReadOnly = true;
			this.NumberInputBox.Size = new System.Drawing.Size(194, 18);
			this.NumberInputBox.TabIndex = 0;
			// 
			// NumberButton00
			// 
			this.NumberButton00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
			this.NumberButton00.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton00.Location = new System.Drawing.Point(115, 218);
			this.NumberButton00.Name = "NumberButton00";
			this.NumberButton00.Size = new System.Drawing.Size(45, 48);
			this.NumberButton00.TabIndex = 18;
			this.NumberButton00.Text = "00";
			this.NumberButton00.UseVisualStyleBackColor = false;
			this.NumberButton00.Click += new System.EventHandler(this.NumberButton00_Click);
			// 
			// NumberButtonOK
			// 
			this.NumberButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
			this.NumberButtonOK.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButtonOK.ForeColor = System.Drawing.Color.White;
			this.NumberButtonOK.Location = new System.Drawing.Point(166, 164);
			this.NumberButtonOK.Name = "NumberButtonOK";
			this.NumberButtonOK.Size = new System.Drawing.Size(47, 102);
			this.NumberButtonOK.TabIndex = 17;
			this.NumberButtonOK.Text = "OK";
			this.NumberButtonOK.UseVisualStyleBackColor = false;
			this.NumberButtonOK.Click += new System.EventHandler(this.NumberButtonOK_Click);
			// 
			// NumberButtonDelete
			// 
			this.NumberButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
			this.NumberButtonDelete.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButtonDelete.ForeColor = System.Drawing.Color.White;
			this.NumberButtonDelete.Location = new System.Drawing.Point(166, 56);
			this.NumberButtonDelete.Name = "NumberButtonDelete";
			this.NumberButtonDelete.Size = new System.Drawing.Size(47, 48);
			this.NumberButtonDelete.TabIndex = 16;
			this.NumberButtonDelete.Text = "←";
			this.NumberButtonDelete.UseVisualStyleBackColor = false;
			this.NumberButtonDelete.Click += new System.EventHandler(this.NumberButtonDelete_Click);
			// 
			// NumberButtonQuantity
			// 
			this.NumberButtonQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
			this.NumberButtonQuantity.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButtonQuantity.Location = new System.Drawing.Point(166, 110);
			this.NumberButtonQuantity.Name = "NumberButtonQuantity";
			this.NumberButtonQuantity.Size = new System.Drawing.Size(47, 48);
			this.NumberButtonQuantity.TabIndex = 13;
			this.NumberButtonQuantity.Text = "X";
			this.NumberButtonQuantity.UseVisualStyleBackColor = false;
			this.NumberButtonQuantity.Click += new System.EventHandler(this.NumberButtonQuantity_Click);
			// 
			// NumberButton9
			// 
			this.NumberButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton9.Location = new System.Drawing.Point(115, 56);
			this.NumberButton9.Name = "NumberButton9";
			this.NumberButton9.Size = new System.Drawing.Size(45, 48);
			this.NumberButton9.TabIndex = 12;
			this.NumberButton9.Text = "9";
			this.NumberButton9.UseVisualStyleBackColor = false;
			this.NumberButton9.Click += new System.EventHandler(this.NumberButton9_Click);
			// 
			// NumberButton8
			// 
			this.NumberButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton8.Location = new System.Drawing.Point(64, 56);
			this.NumberButton8.Name = "NumberButton8";
			this.NumberButton8.Size = new System.Drawing.Size(45, 48);
			this.NumberButton8.TabIndex = 11;
			this.NumberButton8.Text = "8";
			this.NumberButton8.UseVisualStyleBackColor = false;
			this.NumberButton8.Click += new System.EventHandler(this.NumberButton8_Click);
			// 
			// NumberButton7
			// 
			this.NumberButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton7.Location = new System.Drawing.Point(13, 56);
			this.NumberButton7.Name = "NumberButton7";
			this.NumberButton7.Size = new System.Drawing.Size(45, 48);
			this.NumberButton7.TabIndex = 10;
			this.NumberButton7.Text = "7";
			this.NumberButton7.UseVisualStyleBackColor = false;
			this.NumberButton7.Click += new System.EventHandler(this.NumberButton7_Click);
			// 
			// NumberButton6
			// 
			this.NumberButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton6.Location = new System.Drawing.Point(115, 110);
			this.NumberButton6.Name = "NumberButton6";
			this.NumberButton6.Size = new System.Drawing.Size(45, 48);
			this.NumberButton6.TabIndex = 9;
			this.NumberButton6.Text = "6";
			this.NumberButton6.UseVisualStyleBackColor = false;
			this.NumberButton6.Click += new System.EventHandler(this.NumberButton6_Click);
			// 
			// NumberButton5
			// 
			this.NumberButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton5.Location = new System.Drawing.Point(64, 110);
			this.NumberButton5.Name = "NumberButton5";
			this.NumberButton5.Size = new System.Drawing.Size(45, 48);
			this.NumberButton5.TabIndex = 8;
			this.NumberButton5.Text = "5";
			this.NumberButton5.UseVisualStyleBackColor = false;
			this.NumberButton5.Click += new System.EventHandler(this.NumberButton5_Click);
			// 
			// NumberButton4
			// 
			this.NumberButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton4.Location = new System.Drawing.Point(13, 110);
			this.NumberButton4.Name = "NumberButton4";
			this.NumberButton4.Size = new System.Drawing.Size(45, 48);
			this.NumberButton4.TabIndex = 7;
			this.NumberButton4.Text = "4";
			this.NumberButton4.UseVisualStyleBackColor = false;
			this.NumberButton4.Click += new System.EventHandler(this.NumberButton4_Click);
			// 
			// NumberButton3
			// 
			this.NumberButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton3.Location = new System.Drawing.Point(115, 164);
			this.NumberButton3.Name = "NumberButton3";
			this.NumberButton3.Size = new System.Drawing.Size(45, 48);
			this.NumberButton3.TabIndex = 6;
			this.NumberButton3.Text = "3";
			this.NumberButton3.UseVisualStyleBackColor = false;
			this.NumberButton3.Click += new System.EventHandler(this.NumberButton3_Click);
			// 
			// NumberButton2
			// 
			this.NumberButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton2.Location = new System.Drawing.Point(64, 164);
			this.NumberButton2.Name = "NumberButton2";
			this.NumberButton2.Size = new System.Drawing.Size(45, 48);
			this.NumberButton2.TabIndex = 5;
			this.NumberButton2.Text = "2";
			this.NumberButton2.UseVisualStyleBackColor = false;
			this.NumberButton2.Click += new System.EventHandler(this.NumberButton2_Click);
			// 
			// NumberButton1
			// 
			this.NumberButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton1.Location = new System.Drawing.Point(13, 164);
			this.NumberButton1.Name = "NumberButton1";
			this.NumberButton1.Size = new System.Drawing.Size(45, 48);
			this.NumberButton1.TabIndex = 4;
			this.NumberButton1.Text = "1";
			this.NumberButton1.UseVisualStyleBackColor = false;
			this.NumberButton1.Click += new System.EventHandler(this.NumberButton1_Click);
			// 
			// NumberButtonPeriod
			// 
			this.NumberButtonPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
			this.NumberButtonPeriod.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButtonPeriod.Location = new System.Drawing.Point(64, 218);
			this.NumberButtonPeriod.Name = "NumberButtonPeriod";
			this.NumberButtonPeriod.Size = new System.Drawing.Size(45, 48);
			this.NumberButtonPeriod.TabIndex = 3;
			this.NumberButtonPeriod.Text = "·";
			this.NumberButtonPeriod.UseVisualStyleBackColor = false;
			this.NumberButtonPeriod.Click += new System.EventHandler(this.NumberButtonPeriod_Click);
			// 
			// NumberButton0
			// 
			this.NumberButton0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NumberButton0.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberButton0.Location = new System.Drawing.Point(13, 218);
			this.NumberButton0.Name = "NumberButton0";
			this.NumberButton0.Size = new System.Drawing.Size(45, 48);
			this.NumberButton0.TabIndex = 2;
			this.NumberButton0.Text = "0";
			this.NumberButton0.UseVisualStyleBackColor = false;
			this.NumberButton0.Click += new System.EventHandler(this.NumberButton0_Click);
			// 
			// MainTabber
			// 
			this.MainTabber.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.MainTabber.Controls.Add(this.TransactionPage);
			this.MainTabber.Controls.Add(this.ItemsSelectionPage);
			this.MainTabber.Controls.Add(this.PaymentPage);
			this.MainTabber.Controls.Add(this.CashPaymentPage);
			this.MainTabber.Controls.Add(this.ChangePage);
			this.MainTabber.ItemSize = new System.Drawing.Size(0, 1);
			this.MainTabber.Location = new System.Drawing.Point(12, 12);
			this.MainTabber.Name = "MainTabber";
			this.MainTabber.SelectedIndex = 0;
			this.MainTabber.Size = new System.Drawing.Size(439, 412);
			this.MainTabber.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.MainTabber.TabIndex = 3;
			this.MainTabber.TabStop = false;
			// 
			// TransactionPage
			// 
			this.TransactionPage.Controls.Add(this.TransactionGridView);
			this.TransactionPage.Location = new System.Drawing.Point(4, 5);
			this.TransactionPage.Name = "TransactionPage";
			this.TransactionPage.Padding = new System.Windows.Forms.Padding(3);
			this.TransactionPage.Size = new System.Drawing.Size(431, 403);
			this.TransactionPage.TabIndex = 0;
			this.TransactionPage.Text = "tabPage1";
			this.TransactionPage.UseVisualStyleBackColor = true;
			// 
			// ItemsSelectionPage
			// 
			this.ItemsSelectionPage.Controls.Add(this.ItemSelectionPanel);
			this.ItemsSelectionPage.Location = new System.Drawing.Point(4, 5);
			this.ItemsSelectionPage.Name = "ItemsSelectionPage";
			this.ItemsSelectionPage.Padding = new System.Windows.Forms.Padding(3);
			this.ItemsSelectionPage.Size = new System.Drawing.Size(431, 403);
			this.ItemsSelectionPage.TabIndex = 1;
			this.ItemsSelectionPage.Text = "tabPage2";
			this.ItemsSelectionPage.UseVisualStyleBackColor = true;
			// 
			// ItemSelectionPanel
			// 
			this.ItemSelectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.ItemSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ItemSelectionPanel.Controls.Add(this.ItemSearchListView);
			this.ItemSelectionPanel.Controls.Add(this.ItemSearchInputBoxPanel);
			this.ItemSelectionPanel.Controls.Add(this.ItemSearchAddButton);
			this.ItemSelectionPanel.Controls.Add(this.ItemSearchHeading);
			this.ItemSelectionPanel.Location = new System.Drawing.Point(6, 6);
			this.ItemSelectionPanel.Name = "ItemSelectionPanel";
			this.ItemSelectionPanel.Size = new System.Drawing.Size(419, 391);
			this.ItemSelectionPanel.TabIndex = 0;
			// 
			// ItemSearchListView
			// 
			this.ItemSearchListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.ItemSearchListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
			this.ItemSearchListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemSearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SearchResultsID,
            this.SearchResultsName,
            this.SearchResultsPrice});
			this.ItemSearchListView.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemSearchListView.ForeColor = System.Drawing.Color.White;
			this.ItemSearchListView.FullRowSelect = true;
			this.ItemSearchListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.ItemSearchListView.Location = new System.Drawing.Point(3, 83);
			this.ItemSearchListView.MultiSelect = false;
			this.ItemSearchListView.Name = "ItemSearchListView";
			this.ItemSearchListView.ShowGroups = false;
			this.ItemSearchListView.Size = new System.Drawing.Size(409, 263);
			this.ItemSearchListView.TabIndex = 2;
			this.ItemSearchListView.UseCompatibleStateImageBehavior = false;
			this.ItemSearchListView.View = System.Windows.Forms.View.Details;
			// 
			// SearchResultsID
			// 
			this.SearchResultsID.Text = "ID";
			this.SearchResultsID.Width = 50;
			// 
			// SearchResultsName
			// 
			this.SearchResultsName.Text = "Name";
			this.SearchResultsName.Width = 216;
			// 
			// SearchResultsPrice
			// 
			this.SearchResultsPrice.Text = "Price";
			this.SearchResultsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SearchResultsPrice.Width = 111;
			// 
			// ItemSearchInputBoxPanel
			// 
			this.ItemSearchInputBoxPanel.BackColor = System.Drawing.SystemColors.Window;
			this.ItemSearchInputBoxPanel.Controls.Add(this.ItemSearchInputBox);
			this.ItemSearchInputBoxPanel.Location = new System.Drawing.Point(3, 28);
			this.ItemSearchInputBoxPanel.Name = "ItemSearchInputBoxPanel";
			this.ItemSearchInputBoxPanel.Size = new System.Drawing.Size(409, 49);
			this.ItemSearchInputBoxPanel.TabIndex = 7;
			// 
			// ItemSearchInputBox
			// 
			this.ItemSearchInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemSearchInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemSearchInputBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemSearchInputBox.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ItemSearchInputBox.Location = new System.Drawing.Point(14, 12);
			this.ItemSearchInputBox.MaxLength = 32;
			this.ItemSearchInputBox.Name = "ItemSearchInputBox";
			this.ItemSearchInputBox.Size = new System.Drawing.Size(379, 25);
			this.ItemSearchInputBox.TabIndex = 1;
			this.ItemSearchInputBox.Text = "item name";
			this.ItemSearchInputBox.TextChanged += new System.EventHandler(this.ItemSearchInputBox_TextChanged);
			// 
			// ItemSearchAddButton
			// 
			this.ItemSearchAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.ItemSearchAddButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemSearchAddButton.Location = new System.Drawing.Point(212, 352);
			this.ItemSearchAddButton.Name = "ItemSearchAddButton";
			this.ItemSearchAddButton.Size = new System.Drawing.Size(200, 32);
			this.ItemSearchAddButton.TabIndex = 6;
			this.ItemSearchAddButton.Text = "Add Selected Item";
			this.ItemSearchAddButton.UseVisualStyleBackColor = false;
			this.ItemSearchAddButton.Click += new System.EventHandler(this.ItemSearchAddButton_Click);
			// 
			// ItemSearchHeading
			// 
			this.ItemSearchHeading.AutoSize = true;
			this.ItemSearchHeading.ForeColor = System.Drawing.Color.White;
			this.ItemSearchHeading.Location = new System.Drawing.Point(3, 5);
			this.ItemSearchHeading.Name = "ItemSearchHeading";
			this.ItemSearchHeading.Size = new System.Drawing.Size(153, 20);
			this.ItemSearchHeading.TabIndex = 0;
			this.ItemSearchHeading.Text = "Search for an item...";
			// 
			// PaymentPage
			// 
			this.PaymentPage.Controls.Add(this.PaymentPanel);
			this.PaymentPage.Location = new System.Drawing.Point(4, 5);
			this.PaymentPage.Name = "PaymentPage";
			this.PaymentPage.Padding = new System.Windows.Forms.Padding(3);
			this.PaymentPage.Size = new System.Drawing.Size(431, 403);
			this.PaymentPage.TabIndex = 2;
			this.PaymentPage.Text = "tabPage1";
			this.PaymentPage.UseVisualStyleBackColor = true;
			// 
			// PaymentPanel
			// 
			this.PaymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.PaymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PaymentPanel.Controls.Add(this.PaymentCancelButton);
			this.PaymentPanel.Controls.Add(this.PaymentCardLabel);
			this.PaymentPanel.Controls.Add(this.PaymentCashLabel);
			this.PaymentPanel.Controls.Add(this.PaymentCardButton);
			this.PaymentPanel.Controls.Add(this.PaymentCashButton);
			this.PaymentPanel.Controls.Add(this.PaymentMethodHeader);
			this.PaymentPanel.Location = new System.Drawing.Point(6, 6);
			this.PaymentPanel.Name = "PaymentPanel";
			this.PaymentPanel.Size = new System.Drawing.Size(419, 391);
			this.PaymentPanel.TabIndex = 0;
			// 
			// PaymentCancelButton
			// 
			this.PaymentCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.PaymentCancelButton.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PaymentCancelButton.Location = new System.Drawing.Point(212, 352);
			this.PaymentCancelButton.Name = "PaymentCancelButton";
			this.PaymentCancelButton.Size = new System.Drawing.Size(200, 32);
			this.PaymentCancelButton.TabIndex = 6;
			this.PaymentCancelButton.Text = "Cancel Payment";
			this.PaymentCancelButton.UseVisualStyleBackColor = false;
			this.PaymentCancelButton.Click += new System.EventHandler(this.PaymentCancelButton_Click);
			// 
			// PaymentCardLabel
			// 
			this.PaymentCardLabel.AutoSize = true;
			this.PaymentCardLabel.ForeColor = System.Drawing.Color.White;
			this.PaymentCardLabel.Location = new System.Drawing.Point(249, 207);
			this.PaymentCardLabel.Name = "PaymentCardLabel";
			this.PaymentCardLabel.Size = new System.Drawing.Size(40, 20);
			this.PaymentCardLabel.TabIndex = 5;
			this.PaymentCardLabel.Text = "Card";
			// 
			// PaymentCashLabel
			// 
			this.PaymentCashLabel.AutoSize = true;
			this.PaymentCashLabel.ForeColor = System.Drawing.Color.White;
			this.PaymentCashLabel.Location = new System.Drawing.Point(130, 207);
			this.PaymentCashLabel.Name = "PaymentCashLabel";
			this.PaymentCashLabel.Size = new System.Drawing.Size(40, 20);
			this.PaymentCashLabel.TabIndex = 4;
			this.PaymentCashLabel.Text = "Cash";
			// 
			// PaymentMethodHeader
			// 
			this.PaymentMethodHeader.AutoSize = true;
			this.PaymentMethodHeader.ForeColor = System.Drawing.Color.White;
			this.PaymentMethodHeader.Location = new System.Drawing.Point(3, 6);
			this.PaymentMethodHeader.Name = "PaymentMethodHeader";
			this.PaymentMethodHeader.Size = new System.Drawing.Size(206, 20);
			this.PaymentMethodHeader.TabIndex = 1;
			this.PaymentMethodHeader.Text = "Choose a payment method...";
			// 
			// TransactionFooterPanel
			// 
			this.TransactionFooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
			this.TransactionFooterPanel.Controls.Add(this.TotalPriceLabel);
			this.TransactionFooterPanel.Controls.Add(this.TotalLabel);
			this.TransactionFooterPanel.Location = new System.Drawing.Point(12, 430);
			this.TransactionFooterPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.TransactionFooterPanel.Name = "TransactionFooterPanel";
			this.TransactionFooterPanel.Size = new System.Drawing.Size(446, 57);
			this.TransactionFooterPanel.TabIndex = 4;
			// 
			// TotalPriceLabel
			// 
			this.TotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TotalPriceLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalPriceLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.TotalPriceLabel.Location = new System.Drawing.Point(318, 16);
			this.TotalPriceLabel.Name = "TotalPriceLabel";
			this.TotalPriceLabel.Size = new System.Drawing.Size(126, 27);
			this.TotalPriceLabel.TabIndex = 1;
			this.TotalPriceLabel.Text = "$0.00";
			this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TotalLabel
			// 
			this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TotalLabel.AutoSize = true;
			this.TotalLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.TotalLabel.Location = new System.Drawing.Point(244, 16);
			this.TotalLabel.Name = "TotalLabel";
			this.TotalLabel.Size = new System.Drawing.Size(68, 27);
			this.TotalLabel.TabIndex = 0;
			this.TotalLabel.Text = "Total:";
			// 
			// ItemWatcher
			// 
			this.ItemWatcher.EnableRaisingEvents = true;
			this.ItemWatcher.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)));
			this.ItemWatcher.SynchronizingObject = this;
			// 
			// CashPaymentPage
			// 
			this.CashPaymentPage.Controls.Add(this.CashPaymentPanel);
			this.CashPaymentPage.Location = new System.Drawing.Point(4, 5);
			this.CashPaymentPage.Name = "CashPaymentPage";
			this.CashPaymentPage.Padding = new System.Windows.Forms.Padding(3);
			this.CashPaymentPage.Size = new System.Drawing.Size(431, 403);
			this.CashPaymentPage.TabIndex = 3;
			this.CashPaymentPage.Text = "tabPage1";
			this.CashPaymentPage.UseVisualStyleBackColor = true;
			// 
			// CashPaymentPanel
			// 
			this.CashPaymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
			this.CashPaymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CashPaymentPanel.Controls.Add(this.CashPaymentParagraph);
			this.CashPaymentPanel.Controls.Add(this.CashPaymentHeader);
			this.CashPaymentPanel.Location = new System.Drawing.Point(6, 6);
			this.CashPaymentPanel.Name = "CashPaymentPanel";
			this.CashPaymentPanel.Size = new System.Drawing.Size(419, 391);
			this.CashPaymentPanel.TabIndex = 0;
			// 
			// PaymentCardButton
			// 
			this.PaymentCardButton.ForeColor = System.Drawing.Color.DimGray;
			this.PaymentCardButton.Image = global::POS.Properties.Resources.ic_credit_card_black_24dp;
			this.PaymentCardButton.Location = new System.Drawing.Point(221, 111);
			this.PaymentCardButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.PaymentCardButton.Name = "PaymentCardButton";
			this.PaymentCardButton.Size = new System.Drawing.Size(96, 96);
			this.PaymentCardButton.TabIndex = 3;
			this.PaymentCardButton.UseVisualStyleBackColor = true;
			this.PaymentCardButton.Click += new System.EventHandler(this.PaymentCardButton_Click);
			// 
			// PaymentCashButton
			// 
			this.PaymentCashButton.ForeColor = System.Drawing.Color.DimGray;
			this.PaymentCashButton.Image = global::POS.Properties.Resources.ic_attach_money_black_24dp;
			this.PaymentCashButton.Location = new System.Drawing.Point(105, 111);
			this.PaymentCashButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.PaymentCashButton.Name = "PaymentCashButton";
			this.PaymentCashButton.Size = new System.Drawing.Size(96, 96);
			this.PaymentCashButton.TabIndex = 2;
			this.PaymentCashButton.UseVisualStyleBackColor = true;
			this.PaymentCashButton.Click += new System.EventHandler(this.PaymentCashButton_Click);
			// 
			// CashPaymentHeader
			// 
			this.CashPaymentHeader.AutoSize = true;
			this.CashPaymentHeader.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CashPaymentHeader.ForeColor = System.Drawing.Color.White;
			this.CashPaymentHeader.Location = new System.Drawing.Point(3, 6);
			this.CashPaymentHeader.Name = "CashPaymentHeader";
			this.CashPaymentHeader.Size = new System.Drawing.Size(141, 27);
			this.CashPaymentHeader.TabIndex = 0;
			this.CashPaymentHeader.Text = "Cash Payment";
			// 
			// CashPaymentParagraph
			// 
			this.CashPaymentParagraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
			this.CashPaymentParagraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CashPaymentParagraph.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CashPaymentParagraph.ForeColor = System.Drawing.Color.White;
			this.CashPaymentParagraph.Location = new System.Drawing.Point(25, 108);
			this.CashPaymentParagraph.Name = "CashPaymentParagraph";
			this.CashPaymentParagraph.Size = new System.Drawing.Size(364, 109);
			this.CashPaymentParagraph.TabIndex = 1;
			this.CashPaymentParagraph.Text = "Enter the amount of cash received in the number pad on the right, then press OK.";
			this.CashPaymentParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChangePage
			// 
			this.ChangePage.Controls.Add(this.ChangePanel);
			this.ChangePage.Location = new System.Drawing.Point(4, 5);
			this.ChangePage.Name = "ChangePage";
			this.ChangePage.Padding = new System.Windows.Forms.Padding(3);
			this.ChangePage.Size = new System.Drawing.Size(431, 403);
			this.ChangePage.TabIndex = 4;
			this.ChangePage.Text = "tabPage1";
			this.ChangePage.UseVisualStyleBackColor = true;
			// 
			// ChangePanel
			// 
			this.ChangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.ChangePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ChangePanel.Controls.Add(this.DrawerReminderLabel);
			this.ChangePanel.Controls.Add(this.ChangeDisplayPanel);
			this.ChangePanel.Controls.Add(this.ChangePageHeader);
			this.ChangePanel.Location = new System.Drawing.Point(6, 6);
			this.ChangePanel.Name = "ChangePanel";
			this.ChangePanel.Size = new System.Drawing.Size(419, 391);
			this.ChangePanel.TabIndex = 0;
			// 
			// ChangePageHeader
			// 
			this.ChangePageHeader.AutoSize = true;
			this.ChangePageHeader.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePageHeader.Location = new System.Drawing.Point(3, 6);
			this.ChangePageHeader.Name = "ChangePageHeader";
			this.ChangePageHeader.Size = new System.Drawing.Size(182, 43);
			this.ChangePageHeader.TabIndex = 0;
			this.ChangePageHeader.Text = "Thank You";
			// 
			// ChangeDisplayPanel
			// 
			this.ChangeDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
			this.ChangeDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ChangeDisplayPanel.Controls.Add(this.ChangeLabel);
			this.ChangeDisplayPanel.Controls.Add(this.ChangeLabelHeader);
			this.ChangeDisplayPanel.Location = new System.Drawing.Point(103, 120);
			this.ChangeDisplayPanel.Name = "ChangeDisplayPanel";
			this.ChangeDisplayPanel.Size = new System.Drawing.Size(197, 125);
			this.ChangeDisplayPanel.TabIndex = 1;
			// 
			// ChangeLabelHeader
			// 
			this.ChangeLabelHeader.AutoSize = true;
			this.ChangeLabelHeader.Location = new System.Drawing.Point(17, 20);
			this.ChangeLabelHeader.Name = "ChangeLabelHeader";
			this.ChangeLabelHeader.Size = new System.Drawing.Size(64, 20);
			this.ChangeLabelHeader.TabIndex = 0;
			this.ChangeLabelHeader.Text = "Change:";
			// 
			// ChangeLabel
			// 
			this.ChangeLabel.AutoSize = true;
			this.ChangeLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeLabel.Location = new System.Drawing.Point(16, 46);
			this.ChangeLabel.Name = "ChangeLabel";
			this.ChangeLabel.Size = new System.Drawing.Size(64, 27);
			this.ChangeLabel.TabIndex = 1;
			this.ChangeLabel.Text = "$0.00";
			// 
			// DrawerReminderLabel
			// 
			this.DrawerReminderLabel.AutoSize = true;
			this.DrawerReminderLabel.Location = new System.Drawing.Point(100, 345);
			this.DrawerReminderLabel.Name = "DrawerReminderLabel";
			this.DrawerReminderLabel.Size = new System.Drawing.Size(206, 20);
			this.DrawerReminderLabel.TabIndex = 2;
			this.DrawerReminderLabel.Text = "Please close the cash drawer.";
			// 
			// ChangeDisplayTimer
			// 
			this.ChangeDisplayTimer.Interval = 5000;
			this.ChangeDisplayTimer.Tick += new System.EventHandler(this.ChangeDisplayTimer_Tick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.button1.Enabled = false;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(404, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 42);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(288, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 42);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
			this.button3.Enabled = false;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(172, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 42);
			this.button3.TabIndex = 4;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AcceptButton = this.NumberButtonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.TransactionFooterPanel);
			this.Controls.Add(this.MainTabber);
			this.Controls.Add(this.SidePanel);
			this.Controls.Add(this.FunctionsPanel);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Point-of-Sale System - Marcus Kirkwood - Software Design & Development";
			((System.ComponentModel.ISupportInitialize)(this.TransactionGridView)).EndInit();
			this.FunctionsPanel.ResumeLayout(false);
			this.SidePanel.ResumeLayout(false);
			this.TransactionFunctionsPanel.ResumeLayout(false);
			this.NumbersPanel.ResumeLayout(false);
			this.NumberInputBackgroundPanel.ResumeLayout(false);
			this.NumberInputBackgroundPanel.PerformLayout();
			this.MainTabber.ResumeLayout(false);
			this.TransactionPage.ResumeLayout(false);
			this.ItemsSelectionPage.ResumeLayout(false);
			this.ItemSelectionPanel.ResumeLayout(false);
			this.ItemSelectionPanel.PerformLayout();
			this.ItemSearchInputBoxPanel.ResumeLayout(false);
			this.ItemSearchInputBoxPanel.PerformLayout();
			this.PaymentPage.ResumeLayout(false);
			this.PaymentPanel.ResumeLayout(false);
			this.PaymentPanel.PerformLayout();
			this.TransactionFooterPanel.ResumeLayout(false);
			this.TransactionFooterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemWatcher)).EndInit();
			this.CashPaymentPage.ResumeLayout(false);
			this.CashPaymentPanel.ResumeLayout(false);
			this.CashPaymentPanel.PerformLayout();
			this.ChangePage.ResumeLayout(false);
			this.ChangePanel.ResumeLayout(false);
			this.ChangePanel.PerformLayout();
			this.ChangeDisplayPanel.ResumeLayout(false);
			this.ChangeDisplayPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView TransactionGridView;
		private System.Windows.Forms.Panel FunctionsPanel;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.Panel SidePanel;
		private System.Windows.Forms.TabControl MainTabber;
		private System.Windows.Forms.TabPage TransactionPage;
		private System.Windows.Forms.TabPage ItemsSelectionPage;
		private System.Windows.Forms.Button RandomButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceColumn;
		private System.Windows.Forms.Panel TransactionFooterPanel;
		private System.Windows.Forms.Label TotalPriceLabel;
		private System.Windows.Forms.Label TotalLabel;
		private System.IO.FileSystemWatcher ItemWatcher;
		private System.Windows.Forms.Panel NumbersPanel;
		private System.Windows.Forms.Panel NumberInputBackgroundPanel;
		private System.Windows.Forms.TextBox NumberInputBox;
		private System.Windows.Forms.Button NumberButton00;
		private System.Windows.Forms.Button NumberButtonOK;
		private System.Windows.Forms.Button NumberButtonDelete;
		private System.Windows.Forms.Button NumberButtonQuantity;
		private System.Windows.Forms.Button NumberButton9;
		private System.Windows.Forms.Button NumberButton8;
		private System.Windows.Forms.Button NumberButton7;
		private System.Windows.Forms.Button NumberButton6;
		private System.Windows.Forms.Button NumberButton5;
		private System.Windows.Forms.Button NumberButton4;
		private System.Windows.Forms.Button NumberButton3;
		private System.Windows.Forms.Button NumberButton2;
		private System.Windows.Forms.Button NumberButton1;
		private System.Windows.Forms.Button NumberButtonPeriod;
		private System.Windows.Forms.Button NumberButton0;
		private System.Windows.Forms.Button VoidTransactionButton;
		private System.Windows.Forms.Button VoidLineButton;
		private System.Windows.Forms.Button VoidItemButton;
		private System.Windows.Forms.Panel TransactionFunctionsPanel;
		private System.Windows.Forms.Button ItemSearchButton;
		private System.Windows.Forms.Panel ItemSelectionPanel;
		private System.Windows.Forms.Label ItemSearchHeading;
		private System.Windows.Forms.Button ItemSearchAddButton;
		private System.Windows.Forms.ListView ItemSearchListView;
		private System.Windows.Forms.TextBox ItemSearchInputBox;
		private System.Windows.Forms.ColumnHeader SearchResultsName;
		private System.Windows.Forms.ColumnHeader SearchResultsPrice;
		private System.Windows.Forms.Panel ItemSearchInputBoxPanel;
		private System.Windows.Forms.ColumnHeader SearchResultsID;
		private System.Windows.Forms.TabPage PaymentPage;
		private System.Windows.Forms.Panel PaymentPanel;
		private System.Windows.Forms.Label PaymentMethodHeader;
		private System.Windows.Forms.Button PaymentCashButton;
		private System.Windows.Forms.Button PaymentCardButton;
		private System.Windows.Forms.Label PaymentCardLabel;
		private System.Windows.Forms.Label PaymentCashLabel;
		private System.Windows.Forms.Button PaymentCancelButton;
		private System.Windows.Forms.TabPage CashPaymentPage;
		private System.Windows.Forms.Panel CashPaymentPanel;
		private System.Windows.Forms.Label CashPaymentParagraph;
		private System.Windows.Forms.Label CashPaymentHeader;
		private System.Windows.Forms.TabPage ChangePage;
		private System.Windows.Forms.Panel ChangePanel;
		private System.Windows.Forms.Label DrawerReminderLabel;
		private System.Windows.Forms.Panel ChangeDisplayPanel;
		private System.Windows.Forms.Label ChangeLabel;
		private System.Windows.Forms.Label ChangeLabelHeader;
		private System.Windows.Forms.Label ChangePageHeader;
		private System.Windows.Forms.Timer ChangeDisplayTimer;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

