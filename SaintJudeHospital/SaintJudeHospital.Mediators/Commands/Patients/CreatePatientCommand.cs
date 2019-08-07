using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Commands.Patients
{
    public class CreatePatientCommand : IRequest<CommandHandlerResult>
    {
        public int? Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime CreatedDate { set; get; }
        public string Address { set; get; }
        public string CivilStatus { set; get; }

        public string HomePhoneNumber { set; get; }
        public string PersonalPhoneNumber { set; get; }

        public string EmailAddress { set; get; }

        public int? PatientStatusId { set; get; }
        public CreateParentCommand Parent1 { set; get; }
        public CreateParentCommand Parent2 { set; get; }
    }

    public class CreateParentCommand
    {
        public int Age { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public string Occupation { set; get; }
    }
}
