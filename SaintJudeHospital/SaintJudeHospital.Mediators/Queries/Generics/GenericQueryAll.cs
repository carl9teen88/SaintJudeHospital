using MediatR;
using SaintJudeHospital.Common;
using SaintJudeHospital.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryAll : IRequest<GenericQueryItemsResult>
    {
        public int Page { set; get; }
        public int Rpp { set; get; }
    }

    public class GenericsQueryHandler : RequestHandler<GenericQueryAll, GenericQueryItemsResult>, IMediatorHandler
    {
        private readonly IGenericService _genericService;

        public GenericsQueryHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override GenericQueryItemsResult Handle(GenericQueryAll request)
        {
            var generics = _genericService.GetAll().GetData(request.Page, request.Rpp);

            return new GenericQueryItemsResult
            {
                Generics = generics.Select(g => new GenericQueryResult
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList(),
                Page = generics.Page,
                Rows = generics.Rows,
                TotalPage = generics.TotalPage
            };
        }
    }
}
