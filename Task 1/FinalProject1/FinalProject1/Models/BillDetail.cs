using System;
using Newtonsoft.Json;

namespace Models
{
    public class BillDetail : IComparable<BillDetail>
    {
        [JsonIgnore]
        private static int s_autoId = 1000000;
        [JsonProperty("detailId")]
        public int BillDetailId { get; set; }
        [JsonProperty("card")]
        public Cart Cart { get; set; }
        [JsonProperty("totalPrice")]
        public float TotalPrice { get; set; }

        public BillDetail() { }

        public BillDetail(int id)
        {
            BillDetailId = id == 0 ? s_autoId++ : id;
        }

        public BillDetail(int billDetailId, Cart cart, float totalPrice) : this(billDetailId)
        {
            Cart = cart;
            TotalPrice = totalPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is BillDetail detail &&
                   BillDetailId == detail.BillDetailId;
        }

        public override int GetHashCode()
        {
            return 915409144 + BillDetailId.GetHashCode();
        }

        public int CompareTo(BillDetail other)
        {
            return BillDetailId - other.BillDetailId;
        }
    }
}
