using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementAPI.Models
{
    public class Appoinmentfixing
    {
        [Key]
        public int AppointmentId { get; set; }
        public int PatientID { get; set; }
        public string SpecializationRequired { get; set; }
        string DFirstname { get; set; }
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime FromTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime ToTime { get; set; }

    }
}
