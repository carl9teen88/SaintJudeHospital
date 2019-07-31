using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Laboratory
{
    public class LaboratoryQueryAll : IRequest<IList<LaboratoryQueryResult>>
    {
        // No parameters required
    }

    public class LaboratoryQueryHandler : RequestHandler<LaboratoryQueryAll, IList<LaboratoryQueryResult>>, IMediatorHandler
    {
        private readonly ILaboratoryService _laboratoryService;

        public LaboratoryQueryHandler(ILaboratoryService laboratoryService)
        {
            _laboratoryService = laboratoryService;
        }

        protected override IList<LaboratoryQueryResult> Handle(LaboratoryQueryAll request)
        {
            return _laboratoryService.
                GetAll()
                .Select(l => new LaboratoryQueryResult
                {
                    Id = l.Id,
                    Name = l.Name
                })
                .ToList();
        }
    }
}
