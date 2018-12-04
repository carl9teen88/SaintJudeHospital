using MediatR;
using SaintJudeHospital.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryById : IRequest<GenericQueryIemResult>
    {
        public int Id { set; get; }
    }

    public class GenericQueryByIdHandler : RequestHandler<GenericQueryById, GenericQueryIemResult>, IMediatorHandler
    {
        private readonly IGenericService _genericService;

        public GenericQueryByIdHandler(IGenericService genericService)
        {
            _genericService = genericService;
        }

        protected override GenericQueryIemResult Handle(GenericQueryById request)
        {
            var generic = _genericService.Get(request.Id);

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
