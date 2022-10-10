using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Training_WFM.Models
{
    public class Profiles
    {
        [Key]
        public int profile_id { get; set; }
        public string profile_name { get; set; }
        public ICollection<Employees> employees { get; set; }
    }
}
