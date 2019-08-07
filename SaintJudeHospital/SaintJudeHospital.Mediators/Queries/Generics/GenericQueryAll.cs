using MediatR;
using SaintJudeHospital.Common;
using SaintJudeHospital.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryAll : IRequest<IList<GenericQueryResult>>
    {
        public int Page { set; get; }
        public int Rpp { set; get; }
    }

    public class GenericsQueryHandler : RequestHandler<GenericQueryAll, IList<GenericQueryResult>>, IMediatorHandler
    {
        private readonly IGenericService _genericService;

        public GenericsQueryHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override IList<GenericQueryResult> Handle(GenericQueryAll request)
        {
            return _genericService.GetAll()
                .GetData(request.Page, request.Rpp)
                .Select(g => new GenericQueryResult
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList();
        }
    }
}
