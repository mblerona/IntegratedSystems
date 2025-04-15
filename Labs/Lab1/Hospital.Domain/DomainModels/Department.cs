using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.DomainModels
{
    public class Department
    {
        [Key]

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Floor { get; set; }

  
        
        public virtual ICollection<PatientDepartment> ?patientDepartments { get;   set; }
    }
}
