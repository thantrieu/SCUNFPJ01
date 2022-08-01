using System;
using Newtonsoft.Json;

namespace Models
{
    public class SelectedItem : Item
    {
        [JsonProperty("numOfSelectedItem")]
        public int NumberOfSelectedItem { get; set; }
        [JsonProperty("discount")]
        public Discount Discount { get; set; }
        [JsonProperty("priceAfterDiscount")]
        public float PriceAfterDiscount { get; set; }

        public SelectedItem() { }

        public SelectedItem(int numberOfSelectedItem, Discount discount, float priceAfterDiscount)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            Discount = discount;
            PriceAfterDiscount = priceAfterDiscount;
        }

        public SelectedItem(int itemId, string itemName, string itemType,
            int quantity, string brand, DateTime releaseDate, int price,
            int numberOfSelectedItem, Discount discount, float priceAfterDiscount) :
            base(itemId, itemName, itemType, quantity, brand, releaseDate, price)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            Discount = discount;
            PriceAfterDiscount = priceAfterDiscount;
        }
    }
}
