using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW12.Models
{
    public partial class Patients
    {
        public Patients()
        {
            Prescriptions = new HashSet<Prescriptions>();
        }

        public int IdPatient { get; set; }
        [DisplayName("Imie Pacjenta")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko Pacjenta")]
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
    }
}
