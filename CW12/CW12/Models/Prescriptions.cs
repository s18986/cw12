using System;
using System.Collections.Generic;

namespace CW12.Models
{
    public partial class Prescriptions
    {
        public Prescriptions()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicaments>();
        }

        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientIdPatient { get; set; }
        public DateTime DateDue { get; set; }
        public int? IdDoctor { get; set; }
        public int? IdPatient { get; set; }

        public virtual Doctors Doctor { get; set; }
        public virtual Patients PatientIdPatientNavigation { get; set; }
        public virtual ICollection<PrescriptionMedicaments> PrescriptionMedicaments { get; set; }
    }
}
