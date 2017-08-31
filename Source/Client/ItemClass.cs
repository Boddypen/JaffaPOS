using System;

namespace POS.Client
{

	/// 
	/// <summary>
	///		ItemInfo class.
	/// </summary>
	/// 
	public class ItemInfo
	{
		// How an item's price is measured.
		public enum PriceType
		{
			PerKilogram,
			Quantity
		}

		// The main item database for the store.
		public static ItemInfo[] itemDatabase;


		// Properties of this item object:
		public PriceType priceType;
		public float basePrice;
		public String name;


		/// <summary>
		///		Initializes a new instance of the <see cref="ItemInfo"/> class.
		/// </summary>
		/// 
		/// <param name="name">The name of the item.</param>
		/// <param name="basePrice">The base price.</param>
		/// <param name="priceType">How the item's price is measured.</param>
		/// 
		public ItemInfo(String name, float basePrice, PriceType priceType)
		{
			this.name = name;

			this.basePrice = basePrice;
			this.priceType = priceType;
		}


		/// 
		/// <summary>
		///		Get's an item's information, based on an ID specified.
		/// </summary>
		/// 
		/// <param name="ID">The ID of the item.</param>
		/// 
		/// <returns>The item object of the ID specified.</returns>
		/// 
		/// <exception cref="Exception">Item databse not initialised</exception>
		/// <exception cref="Exception">Unknown item ID</exception>
		/// 
		public static ItemInfo getItemInfo(int ID)
		{
			// Make sure the database has been set up.
			if (itemDatabase == null)
				throw new Exception("Item database has not been initialised yet.");

			// Return the item from the database
			if (ID >= 0 && ID < itemDatabase.Length && itemDatabase[ID] != null)
				return itemDatabase[ID];

			// If nothing has been returned, throw an error.
			throw new Exception("Unknown item ID: " + ID);
		}


	}

}
