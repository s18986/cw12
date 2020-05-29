using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zestaw12.Models
{
    public partial class Doctors
    {
        public Doctors()
        {
            Prescriptions = new HashSet<Prescriptions>();
        }

        public int Id { get; set; }
        [DisplayName("Imię Doktora")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko Doktora")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
    }
}
