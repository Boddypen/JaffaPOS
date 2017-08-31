// Using Statements
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using POS.Client;


namespace POS.Forms
{

	/// 
	/// <summary>
	///		This is the main form that the user looks at when operating the checkout machine.
	/// </summary>
	/// 
	/// <seealso cref="Form" />
	/// 
	/// <remarks>
	///		Created by Marcus Kirkwood (Year 11, 2017),
	///		for a Software Design & Development Project,
	///		hosted by A. Nightscales
	/// </remarks>
	/// 
	public partial class MainForm : Form
	{

		// A random number generator, useful for everything.
		public Random random;

		// The current transaction being processsed by the user.
		public Transaction currentTransaction;


		/// 
		/// <summary>
		///		Main Form Constructor.
		/// </summary>
		/// 
		public MainForm()
		{
			// Set up the random number generator for use.
			random = new Random();

			// Set up the form.
			InitializeComponent();
			

			// Customise the tabber so that it looks better.
			// This will remove the tabs.
			MainTabber.Appearance = TabAppearance.FlatButtons;
			MainTabber.ItemSize = new System.Drawing.Size(0, 1);
			MainTabber.SizeMode = TabSizeMode.Fixed;

			// Make the grid view of the transaction look better.
			TransactionGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			TransactionGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


			// Set up the item database.
			setupItemDatabase();


			// Set up a brand new transaction to begin working with.
			newTransaction();
			
		}


		/// 
		/// <summary>
		///		Overwrites the current transaction with a blank one.
		/// </summary>
		/// 
		public void newTransaction()
		{
			// Overwrite the current transcation with a new one.
			currentTransaction = new Transaction();

			// Clear the grid view.
			TransactionGridView.Rows.Clear();

			// Reset the transaction price display.
			updateTransactionPrice();

			// Clear the numpad
			NumberInputBox.Clear();
		}


		/// 
		/// <summary>
		///		Set up the item database so the system knows what items are called and how much they cost.
		///		This must be called at the start of the program to work properly.
		/// </summary>
		/// 
		public static void setupItemDatabase()
		{

			// Determine whether or not the database file is present.
			String databaseFilePath
				= Path.Combine(Environment.CurrentDirectory,
							   "Databases",
							   "items.jdb");
			
			if(File.Exists(databaseFilePath))
			{
				try
				{
					// Make a new blank database.
					ItemInfo.itemDatabase = new ItemInfo[1024];

					// Read the raw data from the database.
					String[] databaseLines = File.ReadAllLines(databaseFilePath);

					// Go through each entry and add it to the database.
					foreach(String item in databaseLines)
					{
						// Split up the entry into individual data pieces.
						String[] itemEntryData = item.Split(';');

						// Calculate each piece of data.
						int itemEntryID = int.Parse(itemEntryData[0].Trim());
						String itemEntryName = itemEntryData[1].Trim().ToUpper();
						float itemEntryPrice = float.Parse(itemEntryData[2].Trim());
						ItemInfo.PriceType itemEntryPriceType = (ItemInfo.PriceType)Enum.Parse(typeof(ItemInfo.PriceType), itemEntryData[3].Trim());

						// Add it to the list.
						ItemInfo.itemDatabase[itemEntryID] = new ItemInfo(itemEntryName, itemEntryPrice, itemEntryPriceType);
					}
				}
				catch(Exception ex)
				{
					// There was an error while reading the information from the database.
					throw new Exception("Error while reading item database. " + ex.Message + "\n" + ex.StackTrace);
				}
			}
			else
			{
				// The database file doesn't exist.
				throw new Exception("Could not find database file: '" + databaseFilePath + "'.");	
			}
		}


		/// 
		/// <summary>
		///		Does the signature 'beep' of the checkout machines.
		/// </summary>
		/// 
		public static void beep()
		{
			// Beep!
			Console.Beep(765, 250);
		}


		/// 
		/// <summary>
		///		Handles the Click event of the LogoutButton control.
		///		This will log the user out of the checkout system.
		/// </summary>
		/// 
		private void LogoutButton_Click(Object sender, EventArgs e)
		{
			// Exit!
			this.Close();
		}


		/// 
		/// <summary>
		///		Add 1 random item to the transaction.
		///		This is used for debugging purposes.
		/// </summary>
		/// 
		private void RandomButton_Click(Object sender, EventArgs e)
		{
			// Determine the number of items to be scanned.
			int amountSpecified = 1;
			if (isInputAQuantity())
			{
				try
				{
					// Attempt to convert the quantity input into an integer number.
					amountSpecified = int.Parse(NumberInputBox.Text.Substring(4));
				}
				catch { }
			}

			// Create a brand new random item.
			Item item = new Item(random.Next(0, 16), amountSpecified);

			// Add it to the transaction.
			addTransactionItem(item);

			// Overwrite the quantity input so the same number of items isn't scanned again.
			overwriteInputQuantity();
		}


		/// 
		/// <summary>
		///		Adds an item to the transaction.
		/// </summary>
		/// 
		/// <param name="item">
		///		The item in question to be added.
		///	</param>
		/// 
		private void addTransactionItem(Item item)
		{
			// Do the signature 'beep'.
			beep();

			// Add the item to the transaction's item list.
			currentTransaction.addItem(item);
			TransactionGridView.Rows.Add(item.getData());

			// Scroll to the bottom of the transaction view
			scrollToBottom();

			// Update the new price
			updateTransactionPrice();
		}


		/// 
		/// <summary>
		///		Updates the transaction's total price.
		/// </summary>
		/// 
		private void updateTransactionPrice()
		{
			// Determine the total price of the transaction.
			float totalPrice = currentTransaction.getTotalPrice();

			// Set the total price label to the number.
			TotalPriceLabel.Text = "$" + totalPrice.ToString("0.00");
		}


		/// 
		/// <summary>
		///		Scrolls to the bottom of the transaction view.
		/// </summary>
		/// 
		private void scrollToBottom()
		{
			// Only scroll to the bottom if there are an adequate number of rows.
			if(TransactionGridView.RowCount >= 2)
			{
				TransactionGridView.FirstDisplayedScrollingRowIndex
					= TransactionGridView.RowCount - 1;

				TransactionGridView.Rows[TransactionGridView.RowCount - 1].Selected = true;
			}
		}


		#region Number Pad
		
		/// 
		/// <summary>
		///		Overwrites the quantity input, if the input currently represents a quantity.
		/// </summary>
		/// 
		private void overwriteInputQuantity()
		{
			String input = NumberInputBox.Text.Trim();
			
			// If the input contains a quantity input...
			if (input.Contains("QTY"))
			{
				// Make the input display blank.
				NumberInputBox.Clear();
			}
		}


		/// 
		/// <summary>
		///		Determines whether the numpad input is a specific quantity.
		/// </summary>
		/// 
		/// <returns>
		///   <c>true</c> if [input is a quantity]; otherwise, <c>false</c>.
		/// </returns>
		/// 
		private Boolean isInputAQuantity()
		{
			try
			{
				String input = NumberInputBox.Text.Trim();

				return input.Contains("QTY");
			}
			catch
			{
				return false;
			}
		}


		/// 
		/// <summary>
		///		Handles the Click event of the NumberButtonDelete control.
		///		This will erase a single character from the end of the input string.
		/// </summary>
		/// 
		private void NumberButtonDelete_Click(Object sender, EventArgs e)
		{
			overwriteInputQuantity();

			if(NumberInputBox.Text.Length >= 1)
				NumberInputBox.Text = NumberInputBox.Text.Substring(0, NumberInputBox.Text.Length - 1);
		}


		/// 
		/// <summary>
		///		Handles the Click event of the NumberButtonQuantity control.
		///		This will convert the number on the input into a Quantity.
		/// </summary>
		/// 
		private void NumberButtonQuantity_Click(Object sender, EventArgs e)
		{
			String input = NumberInputBox.Text.Trim();

			try
			{
				// Convert the input into an integer.
				int inputQuantity = int.Parse(input);

				// Turn the display into a quantity display
				NumberInputBox.Text = "QTY " + inputQuantity;
			}
			catch { }
		}

		private void NumberButtonPeriod_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "."; }
		private void NumberButton00_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "00"; }
		private void NumberButton0_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "0"; }
		private void NumberButton1_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "1"; }
		private void NumberButton2_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "2"; }
		private void NumberButton3_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "3"; }
		private void NumberButton4_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "4"; }
		private void NumberButton5_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "5"; }
		private void NumberButton6_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "6"; }
		private void NumberButton7_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "7"; }
		private void NumberButton8_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "8"; }
		private void NumberButton9_Click(Object sender, EventArgs e)
		{ overwriteInputQuantity(); NumberInputBox.Text = NumberInputBox.Text + "9"; }

		
		private void VoidItemButton_Click(Object sender, EventArgs e) { voidCurrentItem(); }
		private void VoidLineButton_Click(Object sender, EventArgs e) { voidCurrentLine(); }

		#endregion


		/// 
		/// <summary>
		///		Voids the current item selected in the transaction.
		/// </summary>
		/// 
		private void voidCurrentItem()
		{
			try
			{
				int index = TransactionGridView.SelectedRows[0].Index;

				Item selectedItem = currentTransaction.items[index];

				// Only allow voiding items for quantity-based items.
				if (!ItemInfo.getItemInfo(selectedItem.ID).priceType.Equals(ItemInfo.PriceType.Quantity))
					return;

				// Make sure there is more than 1 item in the current line.
				// If not, void the line instead.
				if (currentTransaction.items[index].amount >= 2.0F)
				{
					// Decrease the amount by 1 (after casting it through an integer, snapping it to the nearest whole number).
					currentTransaction.items[index].amount
						= (float)((int)(currentTransaction.items[index].amount) - 1);

					// Update the data of the selected row.
					TransactionGridView.Rows.RemoveAt(index);
					TransactionGridView.Rows.Insert(index, currentTransaction.items[index].getData());
					TransactionGridView.FirstDisplayedScrollingRowIndex = index;
					TransactionGridView.Rows[index].Selected = true;
					
					// Update the total price of the transaction.
					updateTransactionPrice();
				}
				else
				{
					voidCurrentLine();
				}

			}
			catch { }
		}


		/// 
		/// <summary>
		///		Voids the current line of the transaction.
		/// </summary>
		/// 
		private void voidCurrentLine()
		{
			try
			{
				// Get the index of the selected item. This is for convenience.
				int index = TransactionGridView.SelectedRows[0].Index;

				// Attempt to remove the current item from the transaction.
				currentTransaction.items.RemoveAt(index);
				TransactionGridView.Rows.RemoveAt(index);

				// Update the price of the transaction.
				updateTransactionPrice();

			}
			catch { }
		}


		/// <summary>
		///		Handles the Click event of the VoidTransactionButton control.
		/// </summary>
		private void VoidTransactionButton_Click(Object sender, EventArgs e)
		{
			// Create a new transaction.
			newTransaction();

			// Go back to the normal tab page.
			MainTabber.SelectTab(0);

			// Re-enable the side panel functions, in case they are/were disabled.
			NumbersPanel.Enabled = true;
			TransactionFunctionsPanel.Enabled = true;
		}


		/// 
		/// <summary>
		///		Handles the Click event of the NumberButtonOK control.
		///		This button will perform many functions, such as finalising the transaction
		///		to entering in a payment number when paying with cash.
		/// </summary>
		/// 
		private void NumberButtonOK_Click(Object sender, EventArgs e)
		{
			// Determine what the context scenario is.
			if (MainTabber.SelectedIndex == 0
				 || MainTabber.SelectedIndex == 1)
			{
				// The user is in the middle of a transaction.

				// Only finalise the transaction if there is a sufficient
				// number of items in the transaction list.
				if (currentTransaction.items.Count >= 1)
					finaliseTransaction();
			}
			else if (MainTabber.SelectedIndex == 3)
			{
				// The user is paying with cash.
				
				try
				{
					// Determine the amount entered.
					float inputCashAmount = roundToNearestCent(float.Parse(NumberInputBox.Text.Trim()));
					float requiredCashAmount = roundToNearestCent(currentTransaction.getTotalPrice());
					float change;

					// Make sure it is equal to or greater than the transaction price.
					if(inputCashAmount >= requiredCashAmount)
					{
						// The transaction has been paid for.

						// Calculate the change required.
						change = inputCashAmount - requiredCashAmount;

						// Head over to the change page.
						showChange(change);
					}
				}
				catch { }
			}
		}


		/// 
		/// <summary>
		///		Brings the user to a screen where the required change is displayed.
		///		Shorty after, the system will automatically begin a new transaction.
		/// </summary>
		/// 
		private void showChange(float change)
		{
			// Set the change display to the correct number.
			ChangeLabel.Text = "$" + roundToNearestCent(change).ToString("0.00");

			// Switch over to the change page.
			MainTabber.SelectTab(4);

			// Disable the side controls
			TransactionFunctionsPanel.Enabled = false;
			NumbersPanel.Enabled = false;

			// Set up the timer so the screen returns back to normal after a few seconds.
			ChangeDisplayTimer.Start();
		}


		/// 
		/// <summary>
		///		Finalises the transaction, allowing payment methods to be selected.
		/// </summary>
		/// 
		private void finaliseTransaction()
		{

			// Disable the side panel so the user can't click on the transaction functions and other things
			TransactionFunctionsPanel.Enabled = false;
			NumbersPanel.Enabled = false;

			// Switch the main tabber over to the payment screen.
			MainTabber.SelectTab(2);

		}


		/// 
		/// <summary>
		///		Handles the Click event of the ItemSearchButton control.
		/// </summary>
		/// 
		private void ItemSearchButton_Click(Object sender, EventArgs e)
		{
			toggleTabber();
		}


		/// 
		/// <summary>
		///		Toggles the main tabber control between the transaction screen and the item search screen.
		/// </summary>
		/// 
		private void toggleTabber()
		{
			if(MainTabber.SelectedIndex <= 0)
			{
				// Switch over to the search tab.

				MainTabber.SelectTab(1);
				ItemSearchButton.Text = "← Back to Transaction";

				ItemSearchInputBox.Clear();
				ItemSearchInputBox.Focus();
			}
			else if(MainTabber.SelectedIndex >= 1)
			{
				// Switch back to the transactions tab.

				MainTabber.SelectTab(0);
				ItemSearchButton.Text = "Item Search →";
			}
		}


		/// 
		/// <summary>
		///		Handles the TextChanged event of the ItemSearchInputBox control.
		///		When the text in the search box changes, initiate the search action.
		/// </summary>
		/// 
		private void ItemSearchInputBox_TextChanged(Object sender, EventArgs e)
		{
			updateItemSearchResults();
		}


		/// 
		/// <summary>
		///		Updates the item search results.
		/// </summary>
		/// 
		private void updateItemSearchResults()
		{

			ItemSearchListView.Items.Clear();

			for(int i = 0; i < ItemInfo.itemDatabase.Length; i++)
			{
				// Break out of the step if the item doesn't contain anything...
				if (ItemInfo.itemDatabase[i] == null) break;

				// Otherwise, check to see if the item contains part of the search result.
				if(ItemInfo.itemDatabase[i].name.ToUpper().Contains(ItemSearchInputBox.Text.Trim().ToUpper()))
				{

					// The item in question contains part of the search query.
					// Add it to the results list.
					ItemSearchListView.Items.Add(
						new ListViewItem(
							new String[]
							{
								i.ToString(),
								ItemInfo.itemDatabase[i].name,
								"$" + ItemInfo.itemDatabase[i].basePrice.ToString("0.00")
							}));

				}

			}

		}


		/// 
		/// <summary>
		///		Rounds a floating-point number to the nearest 0.05, for when dealing with cash.
		/// </summary>
		/// 
		/// <param name="value">
		///		The raw floating-point value.
		///	</param>
		/// 
		/// <returns>
		///		The input value, rounded to the nearest 0.05
		///	</returns>
		/// 
		private float roundToNearestCent(float value)
		{
			if (value == 0.00F) return 0.00F;

			return (float)(Math.Round(value * 20.0F)) / 20.0F;
		}


		/// 
		/// <summary>
		///		Handles the Click event of the ItemSearchAddButton control.
		///		This will add the currently selected item in the item search results to the transaction.
		/// </summary>
		/// 
		private void ItemSearchAddButton_Click(Object sender, EventArgs e)
		{

			try
			{

				// Determine the ID of the selected search result.
				int itemID = int.Parse(ItemSearchListView.Items[ItemSearchListView.SelectedItems[0].Index].SubItems[0].Text);

				ItemInfo itemInfo = ItemInfo.getItemInfo(itemID);

				// Determine the amount of the item, based on its measurement type.
				float amount = 1.000F;
				switch (itemInfo.priceType)
				{

					case ItemInfo.PriceType.PerKilogram:

						// Convert the entered-in value in the numpad input into a float.
						amount = float.Parse(NumberInputBox.Text.Trim());

						break;


					case ItemInfo.PriceType.Quantity:

						// Determine whether or not the user has input a custom quantity into the input box
						if (isInputAQuantity())
						{
							// (Automatic float cast here)
							amount = int.Parse(NumberInputBox.Text.Substring(4));
						}
						else
						{
							amount = 1.0F;
						}

						break;

				}

				// Now add the item to the transaction.
				addTransactionItem(new Item(itemID, amount));

				// Clear the numpad input
				NumberInputBox.Clear();

				toggleTabber();

			}
			catch { }

		}


		/// 
		/// <summary>
		///		Handles the Click event of the PaymentCancelButton control.
		///		This will return the user back to the transaction screen where the transaction
		///		can be resumed.
		/// </summary>
		/// 
		private void PaymentCancelButton_Click(Object sender, EventArgs e)
		{
			// Select the item search page. This will be temporary.
			MainTabber.SelectTab(1);

			// Re-enable the side panel
			TransactionFunctionsPanel.Enabled = true;
			NumbersPanel.Enabled = true;

			// Toggle the tabber, which will set all button texts accordingly.
			toggleTabber();
		}


		/// 
		/// <summary>
		///		Handles the Click event of the PaymentCashButton control.
		/// </summary>
		/// 
		private void PaymentCashButton_Click(Object sender, EventArgs e)
		{
			// Head over to the cash payment screen.
			MainTabber.SelectTab(3);

			// Make sure the function buttons are disabled, but the keypad remains enabled.
			TransactionFunctionsPanel.Enabled = false;
			NumbersPanel.Enabled = true;
		}


		/// 
		/// <summary>
		///		Handles the Click event of the PaymentCardButton control.
		/// </summary>
		/// 
		private void PaymentCardButton_Click(Object sender, EventArgs e)
		{
			showChange(0.00F);
		}


		/// 
		/// <summary>
		///		Handles the Tick event of the ChangeDisplayTimer control.
		///		This will close the change display window and create a new transaction.
		/// </summary>
		/// 
		private void ChangeDisplayTimer_Tick(Object sender, EventArgs e)
		{
			// Create a new transaction.
			newTransaction();

			// Go back to the normal tab page.
			MainTabber.SelectTab(0);

			// Re-enable the side panel functions
			NumbersPanel.Enabled = true;
			TransactionFunctionsPanel.Enabled = true;

			// Stop the timer, just in case it's still running.
			ChangeDisplayTimer.Stop();
		}

	}
	
}
