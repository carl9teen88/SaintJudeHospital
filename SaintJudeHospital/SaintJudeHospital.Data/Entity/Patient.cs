using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public int? ParentId1 { set; get; }
        public Parent Parent1 { set; get; }
        public int? ParentId2 { set; get; }
        public Parent Parent2 { set; get; }
    }
}
