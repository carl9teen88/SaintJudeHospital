using MediatR;
using SaintJudeHospital.Services.Interfaces;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryById : IRequest<GenericQueryResult>
    {
        public int Id { set; get; }
    }

    public class GenericQueryByIdHandler : RequestHandler<GenericQueryById, GenericQueryResult>, IMediatorHandler
    {
        private readonly IGenericService _genericService;

        public GenericQueryByIdHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override GenericQueryResult Handle(GenericQueryById request)
        {
            var generic = _genericService.Get(request.Id);

            return generic != null ? new GenericQueryResult
            {
                Id = generic.Id,
                Name = generic.Name
            } : null;
        }
    }
}
