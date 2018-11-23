using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Patient
    {
        public int Id { set; get; }       
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime CreatedDate { set; get; }
        public string Address { set; get; }
        public string CivilStatus { set; get; }
        
        public int PatientStatusId { set; get; }
        public PatientStatus PatientStatus { set; get; }

        public int MotherId { set; get; }
        public Parent Mother { set; get; }
        public int FatherId { set; get; }
        public Parent Father { set; get; }
    }
}
