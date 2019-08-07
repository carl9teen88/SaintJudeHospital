using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Commands
{
    public class CommandHandlerResult
    {
        public bool Success { set; get; }
        public string Message { set; get; }
    }
}
