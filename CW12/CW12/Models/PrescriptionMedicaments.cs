using System;
using System.Collections.Generic;

namespace CW12.Models
{
    public partial class PrescriptionMedicaments
    {
        public int IdPrescription { get; set; }
        public int? Dose { get; set; }
        public string Details { get; set; }
        public int? PrescriptionIdPrescription { get; set; }
        public int? MedicamentIdMedicament { get; set; }

        public virtual Medicaments MedicamentIdMedicamentNavigation { get; set; }
        public virtual Prescriptions PrescriptionIdPrescriptionNavigation { get; set; }
    }
}
