using System;
using Newtonsoft.Json;

namespace Models
{
    public class Item : IComparable<Item>
    {
        [JsonIgnore]
        private static int s_autoId = 100000;
        [JsonProperty("id")]
        public int ItemId { get; set; }
        [JsonProperty("name")]
        public string ItemName { get; set; }
        [JsonProperty("type")]
        public string ItemType { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("brand")]
        public string Brand { get; set; }
        [JsonProperty("releaseDate")]
        public DateTime ReleaseDate { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }

        public Item() { }

        public Item(int id)
        {
            if (id == 0)
            {
                ItemId = s_autoId++;
            }
            else
            {
                ItemId = id;
            }
        }

        public Item(int itemId, string itemName, string itemType,
            int quantity, string brand, DateTime releaseDate, int price) : this(itemId)
        {
            ItemName = itemName;
            ItemType = itemType;
            Quantity = quantity;
            Brand = brand;
            ReleaseDate = releaseDate;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   ItemId == item.ItemId;
        }

        public override int GetHashCode()
        {
            return -2113648141 + ItemId.GetHashCode();
        }

        public int CompareTo(Item other)
        {
            return ItemId - other.ItemId;
        }
    }
}
