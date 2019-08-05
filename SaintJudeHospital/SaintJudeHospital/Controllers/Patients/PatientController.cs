using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Patients;
using SaintJudeHospital.Model.Response;

namespace SaintJudeHospital.Controllers.Patients
{
    [Authorize]
    public class PatientController : Controller
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Patients(PatientQueryByFilters filters)
        {
            var patients = await _mediator.Send(filters);

            return ResponseJsonData.Ok(new ResponseOkModel {
                Data = new
                {
                    patients,
                    filters.Page,
                    filters.Rpp
                }
            });
        }
    }
}