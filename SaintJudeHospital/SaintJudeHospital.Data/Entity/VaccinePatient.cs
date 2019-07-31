using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class VaccinePatient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public int VaccineId { set; get; }
        public virtual Vaccine Vaccine { set; get; }
        public int CheckupId { set; get; }
        public virtual Checkup Chekup { set; get; }
        public int PatientId { set; get; }
        public virtual Patient Patient { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}
