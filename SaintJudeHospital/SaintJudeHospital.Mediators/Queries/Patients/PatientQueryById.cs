using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Patients
{
    public class PatientQueryById : IRequest<PatientQueryResult>
    {
        public int Id { set; get; }
    }

    public class PatientQueryByIdHandler : RequestHandler<PatientQueryById, PatientQueryResult>
    {
        private readonly IPatientService _patientService;

        public PatientQueryByIdHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        protected override PatientQueryResult Handle(PatientQueryById request)
        {
            var patient = _patientService.Get(request.Id);

            return patient == null ? null : new PatientQueryResult
            {
                Address = patient.Address,
                Age = patient.Age,
                EmailAddress = patient.EmailAddress,
                FirstName = patient.FirstName,
                Gender = patient.Gender,
                Id = patient.Id,
                LastName = patient.LastName,
                MiddleInitial = patient.MiddleInitial,
                PersonalPhoneNumber = patient.PersonalPhoneNumber
            };
        }
    }
}
