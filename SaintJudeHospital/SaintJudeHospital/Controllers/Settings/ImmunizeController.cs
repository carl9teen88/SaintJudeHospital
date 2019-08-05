using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Immunize;
using SaintJudeHospital.Model.Response;

namespace SaintJudeHospital.Controllers.Settings
{
    [Authorize]
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

            return ResponseJsonData.Ok(new ResponseOkModel { Data = immunizes });
        }

        public async Task<IActionResult> ImmunizeById(int id)
        {
            var immunize = await _mediator.Send(new ImmunizeQueryById { Id = id });

            return ResponseJsonData.Ok(new ResponseOkModel { Data = immunize });
        }
    }
}