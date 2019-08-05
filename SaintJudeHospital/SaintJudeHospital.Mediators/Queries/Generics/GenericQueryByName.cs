using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryByName : IRequest<GenericQueryResult>
    {
        public string Name { set;  get; }
    }

    public class GenericQueryByNameHandler : RequestHandler<GenericQueryByName, GenericQueryResult>
    {
        private readonly IGenericService _genericService;

        public GenericQueryByNameHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override GenericQueryResult Handle(GenericQueryByName request)
        {
            var generic = _genericService.GetByName(request.Name);
            
            var result = generic == null ? null : new GenericQueryResult
            {
                Id = generic.Id,
                Name = generic.Name
            };

            return result;
        }
    }
}
