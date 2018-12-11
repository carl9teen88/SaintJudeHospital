using MediatR;
using SaintJudeHospital.Mediators.Queries.ResponseModel;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryById : IRequest<QueryDefaultResultModel<GenericQueryResult>>
    {
        public int Id { set; get; }
    }

    public class GenericQueryByIdHandler : RequestHandler<GenericQueryById, QueryDefaultResultModel<GenericQueryResult>>, IMediatorHandler
    {
        private readonly IGenericService _genericService;

        public GenericQueryByIdHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override QueryDefaultResultModel<GenericQueryResult> Handle(GenericQueryById request)
        {
            var generic = _genericService.Get(request.Id);

            var message = generic == null ? "Generic Id not found." : null;

            var result = generic == null ? null : new GenericQueryResult
            {
                Id = generic.Id,
                Name = generic.Name
            };

            return new QueryDefaultResultModel<GenericQueryResult>(result, message);
        }
    }
}
