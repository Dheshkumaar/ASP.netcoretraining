using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Training_WFM.Models
{
    public class Softlocks
    {
        public int employee_id { get; set; }
        public string manager { get; set; }
        public DateTime reqdate { get; set; }
        public string status { get; set; }
        public DateTime lastupdated { get; set; }
        [Key]
        public int lockid { get; set; }
        public string requestmessage { get; set; }
        public string wfmremark { get; set; }
        public string managerstatus { get; set; }
        public string mgrstatuscomment { get; set; }
        public DateTime mgrlastupdate { get; set; }
        [JsonIgnore]
        public Employees employees { get; set; }
    }
}
