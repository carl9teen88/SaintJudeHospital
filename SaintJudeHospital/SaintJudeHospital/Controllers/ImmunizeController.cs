using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Immunize;

namespace SaintJudeHospital.Controllers
{
    public class ImmunizeController : Controller
    {
        private readonly IMediator _mediator;

        public ImmunizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> ImmunizationList(int page, int rpp = 10)
        {
            var immunizes = await _mediator.Send(new ImmunizeQueryAll
            {
                Page = page,
                Rpp = rpp
            });

            return Json(new
            {
                Data = immunizes,
                StatusCode = HttpStatusCode.OK
            });
        }

        public async Task<IActionResult> ImmunizeById(int id)
        {
            var immunize = await _mediator.Send(new ImmunizeQueryById { Id = id });

            return Json(new
            {
                Data = immunize,
                StatusCode = HttpStatusCode.OK
            });
        }
    }
}