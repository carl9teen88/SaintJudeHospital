using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SaintJudeHospital.Controllers.Settings
{
    [Authorize]
    public class BrandController : Controller
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}