using MediatR;
using SaintJudeHospital.Mediators.Queries.ResponseModel;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryByName : IRequest<QueryDefaultResultModel<GenericQueryResult>>
    {
        public string Name { set;  get; }
    }

    public class GenericQueryByNameHandler : RequestHandler<GenericQueryByName, QueryDefaultResultModel<GenericQueryResult>>
    {
        private readonly IGenericService _genericService;

        public GenericQueryByNameHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override QueryDefaultResultModel<GenericQueryResult> Handle(GenericQueryByName request)
        {
            var generic = _genericService.GetByName(request.Name);

            var message = generic == null ? "Generic name not found." : null;

            var result = generic == null ? null : new GenericQueryResult
            {
                Id = generic.Id,
                Name = generic.Name
            };

            return new QueryDefaultResultModel<GenericQueryResult>(result, message);
        }
    }
}
