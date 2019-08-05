using MediatR;
using SaintJudeHospital.Services.Interfaces;

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
            var immunize = _immunizationService.GetById(request.Id);

            return immunize == null ? null : new ImmunizeQueryResult
            {
                Id = immunize.Id,
                Amount = immunize.Amount,
                Name = immunize.Name
            };
        }
    }
}
