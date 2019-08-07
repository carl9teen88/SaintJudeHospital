using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Patients
{
    public class PatientQueryById : IRequest<PatientQueryByIdResult>
    {
        public int Id { set; get; }
    }

    public class PatientQueryByIdHandler : RequestHandler<PatientQueryById, PatientQueryByIdResult>
    {
        private readonly IPatientService _patientService;

        public PatientQueryByIdHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        protected override PatientQueryByIdResult Handle(PatientQueryById request)
        {
            var patient = _patientService.Get(request.Id);

            return patient == null ? null : new PatientQueryByIdResult
            {
                Address = patient.Address,
                Age = patient.Age,
                EmailAddress = patient.EmailAddress,
                FirstName = patient.FirstName,
                Gender = patient.Gender,
                Id = patient.Id,
                LastName = patient.LastName,
                MiddleName = patient.MiddleName,
                PersonalPhoneNumber = patient.PersonalPhoneNumber,
                CivilStatus = patient.CivilStatus,
                HomePhoneNumber = patient.HomePhoneNumber,
                Parent1 = new ParentQueryResult
                {
                    Age = patient.Parent1.Age,
                    FirstName = patient.Parent1.FirstName,
                    Id = patient.Parent1.Id,
                    LastName = patient.Parent1.LastName,
                    MiddleName = patient.Parent1.MiddleName,
                    Occupation = patient.Parent1.Occupation
                },
                Parent2 = new ParentQueryResult
                {
                    Age = patient.Parent2.Age,
                    FirstName = patient.Parent2.FirstName,
                    Id = patient.Parent2.Id,
                    LastName = patient.Parent2.LastName,
                    MiddleName = patient.Parent2.MiddleName,
                    Occupation = patient.Parent2.Occupation
                }
            };
        }
    }
}
