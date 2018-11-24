using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class VaccinePatient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int VaccineId { set; get; }
        public Vaccine Vaccine { set; get; }
        public int CheckupId { set; get; }
        public Checkup Chekup { set; get; }
        public int PatientId { set; get; }
        public Patient Patient { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}
