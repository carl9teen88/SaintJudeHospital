using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class MedicalCertificate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int PatientId { set; get; }
        public Patient Patient { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime DateOfBirth { set; get; } 
        public string Diagnosis { set; get; }
        public string Operation { set; get; }
        public string Remarks { set; get; }
        public string Requestor { set; get; }
    }
}
