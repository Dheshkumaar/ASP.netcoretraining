using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Training_WFM.Models
{
    public class Users
    {
        [Key]
        public string username { get; set; }
        [JsonIgnore]
        public string password { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string email { get; set; }
    }
}
