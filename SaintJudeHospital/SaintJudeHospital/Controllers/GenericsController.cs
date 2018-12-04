using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Mediators.Queries.Generics;

namespace SaintJudeHospital.Controllers
{
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

            if (generic.IsSuccess)
            {
                return Json(new
                {
                    Data = generic,
                    Status = HttpStatusCode.OK
                });
            }
            else
            {
                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = "Generic id not found."
                });
            }
        }

        public IActionResult GenericByName(string name)
        {
            var generic = _mediator.Send(new GenericQueryByName { Name = name }).Result;

            if(generic.IsSuccess)
            {
                return Json(new
                {
                    Data = generic,
                    Status = HttpStatusCode.OK
                });
            }
            else
            {
                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = "Generic name not found."
                });
            }
        }
    }
}