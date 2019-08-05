using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Patients
{
    public class PatientQueryResult
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleInitial { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string PersonalPhoneNumber { set; get; }
        public string EmailAddress { set; get; }
    }
}
