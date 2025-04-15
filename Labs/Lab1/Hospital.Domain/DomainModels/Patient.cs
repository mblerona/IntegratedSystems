using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.DomainModels
{
    public class Patient
    {
        [Key]

        public Guid Id { get; set; }
        [Required]
       public string? FirstName { get; set; }
        [Required]
        public string? LastName    { get; set; }
        [Required]
        public string? DateOfBirth { get; set; }
        [Required]
        public DateOnly? AdmissionDate { get; set; }
        public virtual ICollection<PatientDepartment>? patientDepartments { get; set; }
        public virtual ICollection<Treatment>? patientsTreatments { get; set; }
    }
}
