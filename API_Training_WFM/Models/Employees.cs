using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Training_WFM.Models
{
    public class Employees
    {
        [Key]
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string status { get; set; }
        public string manager { get; set; }
        public string wfm_manager { get; set; }
        public string email { get; set; }
        public string lockstatus { get; set; }
        public decimal experience { get; set; }
        public int ProfileId { get; set; }
        [JsonIgnore]
        public Profiles profile { get; set; }
        [JsonIgnore]
        public ICollection<Skillmaps> Skillmaps { get; set; }
        [JsonIgnore]
        public ICollection<Softlocks> softlocks { get; set; }

    }

    public class EmployeewithSkills
    {
        [Key]
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string status { get; set; }
        public string manager { get; set; }
        public string wfm_manager { get; set; }
        public string email { get; set; }
        public string lockstatus { get; set; }
        public decimal experience { get; set; }
        public string Profilename { get; set; }
        public List<string> Skills { get; set; }
    }
}
