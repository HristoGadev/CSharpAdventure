using System;
using System.Collections.Generic;

namespace HospitalDatabaseDataModels
{
    public class Patient
    {
      
        public Patient()
        {
            this.Diagnoses = new HashSet<Diagnose>();
            this.Medicaments = new HashSet<Medicament>();
            this.Visitations = new HashSet<Visitation>();
            this.Prescriptions = new HashSet<PatientMedicament>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool HasInsurance { get; set; }

        public ICollection<Diagnose>Diagnoses { get; set; }

        public ICollection<Medicament> Medicaments { get; set; }
        public ICollection<Visitation> Visitations { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; }


    }
}
