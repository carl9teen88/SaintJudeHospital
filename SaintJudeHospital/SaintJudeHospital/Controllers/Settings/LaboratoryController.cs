using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Laboratory;

namespace SaintJudeHospital.Controllers.Settings
{
    public class LaboratoryController : Controller
    {
        private readonly IMediator _mediator;

        public LaboratoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> All()
        {
            var laboratories = await _mediator.Send(new LaboratoryQueryAll());

            return Json(new
            {
                Data = laboratories,
                Status = HttpStatusCode.OK
            });
        }
    }
}