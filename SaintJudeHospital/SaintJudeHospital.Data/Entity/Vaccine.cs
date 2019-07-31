using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Vaccine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }        
        public int Dose { set; get; }
        public int Booster { set; get; }
        public int Price { set; get; }
        public int VaccineTypeId { set; get; }
        public VaccineType VaccineType { set; get; }  
        public DateTime CreatedDate { set; get; }
    }
}
