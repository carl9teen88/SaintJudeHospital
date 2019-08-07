using MediatR;
using SaintJudeHospital.Data.Entity;

namespace SaintJudeHospital.Mediators.Commands.Patients
{
    public class DeletePatientCommandHandler : RequestHandler<DeletePatientCommand, CommandHandlerResult>
    {
        private readonly AppDbContext _context;

        public DeletePatientCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        protected override CommandHandlerResult Handle(DeletePatientCommand request)
        {
            var result = new CommandHandlerResult
            {
                Success = true,
                Message = "Successfully deleted!"
            };

            var bill = _context.Bills.Find(request.Id);

            // Bill status is equal to pending.

            if (bill.BillStatusId == 2) result.Success = false;

            if(result.Success)
            {
                var patient = _context.Patients.Find(bill.PatientId);

                patient.PatientStatusId = 2; // Deleted

                _context.SaveChanges();
            }
            else
            {
                result.Message = "Cannot delete patient entry, bill status is not yet paid.";
            }                
            return result;
        }
    }
}
