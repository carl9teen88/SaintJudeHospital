using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Laboratory;
using SaintJudeHospital.Model.Response;

namespace SaintJudeHospital.Controllers.Settings
{
    [Authorize]
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

            return ResponseJsonData.Ok(laboratories);
        }

        public async Task<IActionResult> Get(int id)
        {
            var laboratory = await _mediator.Send(new LaboratoryQueryById { Id = id });

            return ResponseJsonData.Ok(laboratory);
        }
    }
}