using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Commands.Patients;
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

            return ResponseJsonData.Ok(new
            {
                patients,
                filters.Page,
                filters.Rpp
            });
        }

        public async Task<IActionResult> Create(CreatePatientCommand command)
        {
            if (ModelState.IsValid)
            {
                var response = await _mediator.Send(command);

                return response.Success
                    ? ResponseJsonData.Ok(command, response.Message)
                    : ResponseJsonData.Error(response.Message);
            }
            return ResponseJsonData.Error("Required field(s) is empty.");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var patient = await _mediator.Send(new PatientQueryById { Id = id });

            return ResponseJsonData.Ok(patient);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeletePatientCommand { Id = id });

            return response.Success
                ? ResponseJsonData.Ok(id, response.Message)
                : ResponseJsonData.Error(response.Message);
        }
    }
}