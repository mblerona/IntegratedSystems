using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.DomainModels
{
    public class PatientDepartment
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly DateAssigned { get; set; }

        public Guid PatientId { get; set; } 
        public Patient? patient { get; set; }
        public Guid DepartmentId{ get; set; }
        public Department? department { get; set; }


    }
}
