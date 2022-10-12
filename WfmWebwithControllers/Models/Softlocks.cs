using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WfmWeb.Models
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

        [Required(ErrorMessage = "Request message is required")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Minimum:10 Maximum:30 letters allowed")]
        public string requestmessage { get; set; }
        public string wfmremark { get; set; }
        public string managerstatus { get; set; }
        public string mgrstatuscomment { get; set; }
        public DateTime mgrlastupdate { get; set; }
    }
}
