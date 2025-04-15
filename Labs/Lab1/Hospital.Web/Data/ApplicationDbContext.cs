using Hospital.Domain.DomainModels;
using Hospital.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<HospitalApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<PatientDepartment> PatientDepartment { get; set; }
        public virtual DbSet<Treatment> Treatment { get; set; }
    }
}
