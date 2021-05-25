using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementAPI.Models
{
    public class Doctordetails
    {
        [Key]
        public int DoctorID { get; set; }
        [Required]
        public string DFirstName { get; set; }
        public string DLastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Time)]
        public DateTime AppoinmentTime { get; set; }

    }
}
