﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Patients
{
    public class PatientQueryResult
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string PersonalPhoneNumber { set; get; }
        public string EmailAddress { set; get; }
        
    }

    public class PatientQueryByIdResult : PatientQueryResult
    {
        public string CivilStatus { set; get; }
        public string HomePhoneNumber { set; get; }
        public ParentQueryResult Parent1 { set; get; }
        public ParentQueryResult Parent2 { set; get; }
    }

    public class ParentQueryResult
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public int Age { set; get; }
        public string Occupation { set; get; }
    }
}
