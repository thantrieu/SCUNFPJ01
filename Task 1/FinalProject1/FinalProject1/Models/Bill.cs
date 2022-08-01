using System;
using Newtonsoft.Json;

namespace Models
{
    public class Bill : IComparable<Bill>
    {
        [JsonIgnore]
        private static int s_autoId = 1000000;
        [JsonProperty("id")]
        public int BillId { get; set; }
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
        [JsonProperty("createdTime")]
        public DateTime CreatedTime { get; set; }
        [JsonProperty("totalItem")]
        public int TotalItem { get; set; }
        [JsonProperty("subTotal")]
        public float SubTotal { get; set; }
        [JsonProperty("totalDiscount")]
        public float TotalDiscount { get; set; }
        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }
        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        public Bill() { }

        public Bill(int billId)
        {
            BillId = billId == 0 ? s_autoId++ : billId;
        }

        public Bill(int billId, Customer customer, DateTime createdTime,
            int totalItem, float subTotal, float totalDiscount, float totalAmount,
            string paymentType) : this(billId)
        {
            Customer = customer;
            CreatedTime = createdTime;
            TotalItem = totalItem;
            SubTotal = subTotal;
            TotalDiscount = totalDiscount;
            TotalAmount = totalAmount;
            PaymentType = paymentType;
        }

        public override bool Equals(object obj)
        {
            return obj is Bill bill &&
                   BillId == bill.BillId;
        }

        public override int GetHashCode()
        {
            return 740390073 + BillId.GetHashCode();
        }

        public int CompareTo(Bill other)
        {
            return BillId - other.BillId;
        }
    }
}
