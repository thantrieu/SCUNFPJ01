using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public class Person : IComparable<Person>
    {
        [JsonProperty("id")]
        public string PersonId { get; set; }
        [JsonProperty("fullName")]
        public FullName FullName { get; set; }
        [JsonProperty("birthdate")]
        public DateTime BirthDate { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        public Person()
        {
            FullName = new FullName();
        }

        public Person(string id)
        {
            PersonId = id;
            FullName = new FullName();
        }

        public Person(string personId, string fullName,
            DateTime birthDate, string address, string phoneNumber)
        {
            PersonId = personId;
            FullName = new FullName(fullName);
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public int CompareTo(Person other)
        {
            return PersonId.CompareTo(other.PersonId);
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   PersonId == person.PersonId;
        }

        public override int GetHashCode()
        {
            return -1255590651 + EqualityComparer<string>.Default.GetHashCode(PersonId);
        }
    }
}
