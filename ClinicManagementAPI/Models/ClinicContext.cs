using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementAPI.Models
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        { }
        
        public DbSet<Userlogin> userlogindetails { get; set; }
        public DbSet<Patientdetails> patientdetails { get; set; }
        public DbSet<FOstafflogin> fostaffdetails { get; set; }
        public DbSet<Doctordetails> doctordetails { get; set; }
        public DbSet<Appoinmentfixing> appoinmentdetails { get; set; }
        
    }
}
