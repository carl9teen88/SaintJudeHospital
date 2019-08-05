using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Laboratory
{
    public class LaboratoryQueryById : IRequest<LaboratoryQueryResult>
    {
        public int Id { set; get; }
    }

    public class LaboratoryQueryByIdHandler : RequestHandler<LaboratoryQueryById, LaboratoryQueryResult>
    {
        private readonly ILaboratoryService _laboratoryService;

        public LaboratoryQueryByIdHandler(ILaboratoryService laboratoryService)
        {
            _laboratoryService = laboratoryService;
        }

        protected override LaboratoryQueryResult Handle(LaboratoryQueryById request)
        {
            var laboratory = _laboratoryService.Get(request.Id);

            return laboratory == null ? null : new LaboratoryQueryResult
            {
                Id = laboratory.Id,
                Name = laboratory.Name
            };
        }
    }
}
