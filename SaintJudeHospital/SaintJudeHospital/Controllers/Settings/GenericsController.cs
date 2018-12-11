using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Generics;

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

        public IActionResult GenericList(int page, int rpp = 20)
        {
            var generics = _mediator.Send(new GenericQueryAll { Page = page, Rpp = rpp }).Result;

            return Json(new
            {
                Data = generics,
                Status = HttpStatusCode.OK
            });
        }

        public IActionResult GenericById(int id)
        {
            var generic = _mediator.Send(new GenericQueryById { Id = id }).Result;

            if (generic.Success)
            {
                return Json(new
                {
                    Data = generic.Data,
                    Status = HttpStatusCode.OK
                });
            }
            else
            {
                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = generic.ErrorMessage
                });
            }
        }

        public IActionResult GenericByName(string name)
        {
            var generic = _mediator.Send(new GenericQueryByName { Name = name }).Result;

            if(generic.Success)
            {
                return Json(new
                {
                    Data = generic.Data,
                    Status = HttpStatusCode.OK
                });
            }
            else
            {
                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = generic.ErrorMessage
                });
            }
        }
    }
}