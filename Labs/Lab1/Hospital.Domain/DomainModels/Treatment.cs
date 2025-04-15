using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.DomainModels
{
    public class Treatment
    {
        [Key]

        public Guid Id { get; set; }

        public DateOnly DateAdministered { get; set; }
        public Boolean FollowUpRequired { get; set; }

        public Guid PatientId { get; set; }
        public Patient? patient { get; set; }

    }
}
