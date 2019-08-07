using MediatR;
using SaintJudeHospital.Data.Entity;
using System;

namespace SaintJudeHospital.Mediators.Commands.Patients
{
    public class CreatePatientCommandHandler : RequestHandler<CreatePatientCommand, CommandHandlerResult>
    {
        private readonly AppDbContext _context;

        public CreatePatientCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        protected override CommandHandlerResult Handle(CreatePatientCommand request)
        {
            Patient patient = new Patient
            {
                CreatedDate = DateTime.Now,
                Address = request.Address,
                Age = request.Age,
                CivilStatus = request.CivilStatus,
                DateOfBirth = request.DateOfBirth,
                EmailAddress = request.EmailAddress,
                FirstName = request.FirstName,
                Gender = request.Gender,
                HomePhoneNumber = request.HomePhoneNumber,
                LastName = request.LastName,
                MiddleName = request.MiddleName,
                PersonalPhoneNumber = request.PersonalPhoneNumber,
                Parent1 = new Parent(
                    request.Parent1.Age,
                    request.Parent1.FirstName,
                    request.Parent1.LastName,
                    request.Parent1.MiddleName,
                    request.Parent1.Occupation
                ),
                Parent2 = new Parent(
                    request.Parent2.Age,
                    request.Parent2.FirstName,
                    request.Parent2.LastName,
                    request.Parent2.MiddleName,
                    request.Parent2.Occupation
                )
            };
            request.Id = patient.Id;

            _context.Patients.Add(patient);
            _context.SaveChanges();

            return new CommandHandlerResult
            {
                Success = true,
                Message = "Successfully created!"
            };
        }
    }
}
