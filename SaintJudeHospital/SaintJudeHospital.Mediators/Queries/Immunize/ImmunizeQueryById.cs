using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Immunize
{
    public class ImmunizeQueryById : IRequest<ImmunizeQueryResult>
    {
        public int Id { set; get; }
    }

    public class ImmunizeQueryByIdHandler : RequestHandler<ImmunizeQueryById, ImmunizeQueryResult>, IMediatorHandler
    {
        private readonly IImmunizationService _immunizationService;

        public ImmunizeQueryByIdHandler(IImmunizationService immunizationService)
        {
            _immunizationService = immunizationService;
        }

        protected override ImmunizeQueryResult Handle(ImmunizeQueryById request)
        {
            var immnunize = _immunizationService.GetById(request.Id);

            return new ImmunizeQueryResult
            {
                Id = immnunize.Id,
                Amount = immnunize.Amount,
                Name = immnunize.Name
            };
        }
    }
}
