using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Patients
{
    public class PatientQueryByFilters : IRequest<IList<PatientQueryResult>>
    {
        public int Page { set; get; }
        public int Rpp { set; get; }
        public string SearchKey { set; get; }
    }

    public class PatientQueryByNameHandler : RequestHandler<PatientQueryByFilters, IList<PatientQueryResult>>
    {
        private readonly IPatientService _patientService;

        public PatientQueryByNameHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        protected override IList<PatientQueryResult> Handle(PatientQueryByFilters request)
        {
            var patients = _patientService.GetAll();
            var result = new List<PatientQueryResult>();

            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                patients = patients.Where(p =>
                    p.FirstName.ToLower().Contains(request.SearchKey.ToLower()) ||
                    p.LastName.Contains(request.SearchKey));
            }

            result = patients
                .Skip(request.Rpp * request.Page)
                .Take(request.Rpp)
                .Select(p => new PatientQueryResult
                {
                    Address = p.Address,
                    Age = p.Age,
                    EmailAddress = p.EmailAddress,
                    FirstName = p.FirstName,
                    Gender = p.Gender,
                    Id = p.Id,
                    LastName = p.LastName,
                    MiddleName = p.MiddleName,
                    PersonalPhoneNumber = p.PersonalPhoneNumber
                })
                .ToList();

            return result;
        }
    }
}
