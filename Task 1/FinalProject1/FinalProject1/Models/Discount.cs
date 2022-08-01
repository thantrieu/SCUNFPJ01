using System;
using Newtonsoft.Json;

namespace Models
{
    public class Discount : IComparable<Discount>
    {
        [JsonIgnore]
        private static int s_autoId = 1000000;
        [JsonProperty("id")]
        public int DiscountId { get; set; }
        [JsonProperty("name")]
        public string DiscountName { get; set; }
        [JsonProperty("startAt")]
        public DateTime StartTime { get; set; }
        [JsonProperty("endAt")]
        public DateTime EndTime { get; set; }
        [JsonProperty("type")]
        public string DiscountType { get; set; }
        [JsonProperty("amount")]
        public float DiscountAmount { get; set; }
        [JsonProperty("priceAmount")]
        public float DiscountPriceAmount { get; set; }

        public Discount()
        {
        }

        public Discount(int id)
        {
            DiscountId = id == 0 ? s_autoId++ : id;
        }

        public Discount(int discountId, string discountName, DateTime startTime, 
            DateTime endTime, string discountType, float discountAmount, float discountPriceAmount) : this(discountId)
        {
            DiscountName = discountName;
            StartTime = startTime;
            EndTime = endTime;
            DiscountType = discountType;
            DiscountAmount = discountAmount;
            DiscountPriceAmount = discountPriceAmount;
        }

        public override bool Equals(object obj)
        {
            return obj is Discount discount &&
                   DiscountId == discount.DiscountId;
        }

        public override int GetHashCode()
        {
            return 1574009819 + DiscountId.GetHashCode();
        }

        public int CompareTo(Discount other)
        {
            return DiscountId - other.DiscountId;
        }
    }
}
