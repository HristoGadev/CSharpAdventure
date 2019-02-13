using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDatabaseDataModels
{
    public class Visitation
    {

        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
      

    }
}
