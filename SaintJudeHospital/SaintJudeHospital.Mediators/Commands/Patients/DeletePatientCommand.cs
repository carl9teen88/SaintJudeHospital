using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Commands.Patients
{
    public class DeletePatientCommand : IRequest<CommandHandlerResult>
    {
        public int Id { set; get; }
    }
}
