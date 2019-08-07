using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }       
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get;}
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime CreatedDate { set; get; }
        public string Address { set; get; }
        public string CivilStatus { set; get; }

        public string HomePhoneNumber { set; get; }
        public string PersonalPhoneNumber { set; get; }

        public string EmailAddress { set; get; }
        
        public int PatientStatusId { set; get; }
        public virtual PatientStatus PatientStatus { set; get; }

        public int? ParentId1 { set; get; }
        public virtual Parent Parent1 { set; get; }
        public int? ParentId2 { set; get; }
        public virtual Parent Parent2 { set; get; }

        public ICollection<PatientPhotos> PatientPhotos { set; get; }
    }
}
