using Newtonsoft.Json;

namespace Models
{
    public class FullName
    {
        [JsonProperty("first")]
        public string FirstName { get; set; }
        [JsonProperty("last")]
        public string LastName { get; set; }
        [JsonProperty("mid")]
        public string MidName { get; set; }

        public FullName() { }

        public FullName(string fullName)
        {
            var data = fullName.Split(' ');
            LastName = data[0];
            FirstName = data[data.Length - 1];
            var midName = "";
            for (int i = 1; i < data.Length - 1; i++)
            {
                midName += data[i] + " ";
            }
            MidName = midName.Trim();
        }

        public override string ToString()
        {
            return $"{LastName} {MidName} {FirstName}";
        }
    }
}
