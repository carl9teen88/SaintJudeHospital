using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Vaccine
    {
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
