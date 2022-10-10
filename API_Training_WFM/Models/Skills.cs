using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Training_WFM.Models
{
    public class Skills
    {
        [Key]
        public int skillid { get; set; }
        public string skillname { get; set; }
        public ICollection<Skillmaps> Skillmaps { get; set; }
    }
}
