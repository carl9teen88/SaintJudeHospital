using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class MedicalCertificate
    {
        public int Id { set; get; }
        public int PatientId { set; get; }
        public Patient Patient { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime DateOfBirth { set; get; } 
    }
}
