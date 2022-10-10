using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WfmWeb.Models
{
    public class Users
    {
        [Required(ErrorMessage = "UserName is required")]
        [StringLength(30, MinimumLength = 5,ErrorMessage ="Minimum:5 Maximum:30 letters allowed")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Minimum:8 Maximum:30 letters allowed")]
        public string password { get; set; }
    }
}
