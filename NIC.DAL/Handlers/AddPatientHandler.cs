using CSharpFunctionalExtensions;

using NIC.Core.ValueObjects.Extensions;
using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.ServiceResults;
using NIC.Application.Commands;
using NIC.DAL.BaseModels;


namespace NIC.DAL.Handlers
{
  public class AddPatientHandler : ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand>
  {
    private readonly NicWebApiContext _context;

    public AddPatientHandler(NicWebApiContext context)
    {
      _context = context;
    }

    public async Task<Result<AddPatientResult>> Handle(AddPatientCommand command)
    {
      var PatientBase = new PatientBase
      {
        Id = command.Patient.Id,
        FullName = command.Patient.FullName.ConvertToString(),
        Address = command.Patient.Address,
        Birthday = command.Patient.Birthday,
        Sex = command.Patient.Sex.ToString(),
        StationId = command.Patient.StationId
      };

      await _context.AddAsync(PatientBase);
      await _context.SaveChangesAsync();

      AddPatientResult result = new(command.Patient.Id);

      return Result.Success(result);
    }
  }
}
