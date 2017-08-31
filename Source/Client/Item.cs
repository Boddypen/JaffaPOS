using System;

namespace POS.Client
{

	/// 
	/// <summary>
	///		Item Class.
	/// </summary>
	/// 
	public class Item
	{
		public int ID;

		public float amount;

		public Item()
		{
			this.ID = 0;
			this.amount = 1.00F;
		}

		public Item(int ID, float amount)
		{
			this.ID = ID;

			if (ItemInfo.getItemInfo(this.ID).priceType.Equals(ItemInfo.PriceType.Quantity))
				this.amount = (int)amount;
			else
				this.amount = (float)Math.Round(amount, 3);
		}

		/// <summary>
		///		Gets the data representation of the item.
		/// </summary>
		/// <returns></returns>
		public String[] getData()
		{
			ItemInfo itemInfo = ItemInfo.getItemInfo(this.ID);


			Boolean kg = itemInfo.priceType.Equals(ItemInfo.PriceType.PerKilogram);

			return new String[] { itemInfo.name,

				(kg ? "" : "x")
					+ this.amount.ToString(kg ? "0.000" : null)
					+ (kg ? " KG" : ""),

				"$" + getPrice().ToString("0.00") };
		}

		public float getPrice()
		{
			return (this.amount * ItemInfo.getItemInfo(this.ID).basePrice);
		}
	}

}
