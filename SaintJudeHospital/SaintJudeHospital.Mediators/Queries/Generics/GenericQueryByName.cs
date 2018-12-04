using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryByName : IRequest<GenericQueryIemResult>
    {
        public string Name { set;  get; }
    }

    public class GenericQueryByNameHandler : RequestHandler<GenericQueryByName, GenericQueryIemResult>
    {
        private readonly IGenericService _genericService;

        public GenericQueryByNameHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override GenericQueryIemResult Handle(GenericQueryByName request)
        {
            var generic = _genericService.GetByName(request.Name);

            return new GenericQueryIemResult
            {
                Generic = generic != null ? new GenericQueryResult
                {
                    Id = generic.Id,
                    Name = generic.Name
                } : null
            };
        }
    }
}
