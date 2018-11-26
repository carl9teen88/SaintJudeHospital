using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Immunize
{
    public class ImmunizeQueryAll : IRequest<IList<ImmunizeQueryResult>>
    {
        public int Page { set; get; }
        public int Rpp { set; get; }
    }

    public class ImmunizeQueryHandler : RequestHandler<ImmunizeQueryAll, IList<ImmunizeQueryResult>>, IMediatorHandler
    {
        private readonly IImmunizationService _immunizationService;

        public ImmunizeQueryHandler (IImmunizationService immunizationService)
        {
            _immunizationService = immunizationService;
        }

        protected override IList<ImmunizeQueryResult> Handle(ImmunizeQueryAll request)
        {
            var immunizes = _immunizationService.GetImmunizes(request.Page, request.Rpp);

            return immunizes.Select(i => new ImmunizeQueryResult
            {
                Id = i.Id,
                Name = i.Name,
                Amount = i.Amount
            })
            .ToList();
        }
    }
}
