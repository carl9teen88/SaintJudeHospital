using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Checkup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Gender { set; get; }
        public string Subjective { set; get; }
        public string Objective { set; get; }
        public string Assessment { set; get; }
        public string Prescription { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime NextVisitDate { set; get; }
        public string Weight { set; get; }
        public string Height { set; get; }
        public string HeadCircum { set; get; }
        public string Temperature { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Diagnosis { set; get; }
        public string CivilStatus { set; get; }
    }
}
