using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.Commands;
using NIC.Application.ServiceResults;


namespace NIC.DAL.Handlers
{
  public class DeletePatientHandler : ICommandHandler<Task<Result<DeletePatientResult>>, DeletePatientCommand>
  {
    private readonly NicWebApiContext _context;

    public DeletePatientHandler(NicWebApiContext context)
    {
      _context = context;
    }

    public async Task<Result<DeletePatientResult>> Handle(DeletePatientCommand command)
    {
      await _context.Patients
        .Where(x => x.Id == command.PatientId)
        .ExecuteDeleteAsync();

      DeletePatientResult result = new(command.PatientId);

      return Result.Success(result);
    }
  }
}
