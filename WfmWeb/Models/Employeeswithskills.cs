using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WfmWeb.Models
{
    public class Employeeswithskills
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
        
    }
}
