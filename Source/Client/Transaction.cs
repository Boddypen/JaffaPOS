using System;
using System.Collections.Generic;



namespace POS.Client
{

	/// 
	/// <summary>
	///		A list of items and their quantities.
	/// </summary>
	/// 
	public class Transaction
	{
		// The list of items within the transaction.
		public List<Item> items;


		/// <summary>
		///		Initializes a new instance of the <see cref="Transaction" /> class.
		/// </summary>
		public Transaction()
		{

			// Create a blank item list for the items to go into.
			this.items = new List<Item>();

		}


		/// 
		/// <summary>
		///		Gets the total price of the transaction.
		/// </summary>
		/// 
		/// <returns>The total price of the transacation, in dollars.</returns>
		/// 
		public float getTotalPrice()
		{
			// Make a placeholder variable.
			float totalPriceToReturn = 0.00F;

			// Go through every item and count the price.
			foreach (Item item in items)
				totalPriceToReturn += item.getPrice();

			// Return the total, rounded to 2 decimals (dollars).
			return (float)Math.Round(totalPriceToReturn, 2);
		}


		/// 
		/// <summary>
		///		Add a new item to the end of the transaction.
		/// </summary>
		/// 
		/// <param name="item">The item to be added.</param>
		/// 
		public void addItem(Item item)
		{
			this.items.Add(item);
		}
	}

}
