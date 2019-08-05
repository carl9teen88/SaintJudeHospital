using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Generics;
using SaintJudeHospital.Model.Response;

namespace SaintJudeHospital.Controllers.Settings
{
    [Authorize]
    public class GenericsController : Controller
    {
        private readonly IMediator _mediator;

        public GenericsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GenericList(int page, int rpp = 20)
        {
            var generics = await _mediator.Send(new GenericQueryAll { Page = page, Rpp = rpp });

            return ResponseJsonData.Ok(new ResponseOkModel
            {
                Data = generics
            });
        }

        public async Task<IActionResult> GenericById(int id)
        {
            var generic = await _mediator.Send(new GenericQueryById { Id = id });

            if (generic != null)
            {
                return ResponseJsonData.Ok(new ResponseOkModel
                {
                    Data = generic
                });
            }
            else
            {
                return ResponseJsonData.Error(new ResponseErrorModel
                {
                    Message = "Record not found.",
                    StatusCode = StatusCodeEnum.NotFound
                });
            }
        }

        public async Task<IActionResult> GenericByName(string name)
        {
            var generic = await _mediator.Send(new GenericQueryByName { Name = name });

            if(generic != null)
            {
                return ResponseJsonData.Ok(new ResponseOkModel
                {
                    Data = generic
                });
            }
            else
            {
                return ResponseJsonData.Error(new ResponseErrorModel
                {
                    Message = $"Generic name {name} not found.",
                    StatusCode = StatusCodeEnum.NotFound
                });
            }
        }
    }
}