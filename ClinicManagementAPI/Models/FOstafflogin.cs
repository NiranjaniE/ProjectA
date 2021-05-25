using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementAPI.Models
{
    public class FOstafflogin
    {
        [Key]
        public string SUsername { get; set; }
        [Required]
        [RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.*\d).{8,15}$")]
        public string Password { get; set; }
    }
}
