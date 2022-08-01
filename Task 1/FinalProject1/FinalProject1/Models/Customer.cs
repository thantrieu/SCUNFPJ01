using System;
using Newtonsoft.Json;

namespace Models
{
    public class Customer : Person
    {
        [JsonProperty("type")]
        public string CustomerType { get; set; }
        [JsonProperty("point")]
        public int Point { get; set; }
        [JsonProperty("created")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        public Customer() { }

        public Customer(string customerType, int point, DateTime createdDate, string email)
        {
            CustomerType = customerType;
            Point = point;
            CreatedDate = createdDate;
            Email = email;
        }
    }
}
