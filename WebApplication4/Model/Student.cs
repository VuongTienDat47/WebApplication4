using Newtonsoft.Json;

namespace WebApplication4.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }
}
