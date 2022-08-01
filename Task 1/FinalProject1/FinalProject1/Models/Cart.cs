using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{
    public class Cart : IComparable<Cart>
    {
        [JsonIgnore]
        private static int s_autoId = 10000000;
        [JsonProperty("id")]
        public int CardId { get; set; }
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
        [JsonProperty("items")]
        public List<SelectedItem> SelectedItems { get; set; } = new List<SelectedItem>();
        [JsonProperty("total")]
        public int TotalItems { get; set; }

        public Cart()        {        }

        public Cart(int cardId)
        {
            CardId = cardId == 0 ? s_autoId++ : cardId;
        }

        public Cart(int cardId, Customer customer, List<SelectedItem> selectedItems, int totalItems) : this(cardId)
        {
            Customer = customer;
            SelectedItems = selectedItems;
            TotalItems = totalItems;
        }

        public override bool Equals(object obj)
        {
            return obj is Cart cart &&
                   CardId == cart.CardId;
        }

        public override int GetHashCode()
        {
            return 2024280162 + CardId.GetHashCode();
        }

        public int CompareTo(Cart other)
        {
            return CardId - other.CardId;
        }
    }
}
