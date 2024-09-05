using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.ServiceResults;
using NIC.Application.Queries;


namespace NIC.DAL.Handlers
{
  public class GetByIdForUpdateHandler : ICommandHandler<Task<Result<GetByIdForUpdateResult>>, GetByIdForUpdateCommand>
  {
    private readonly NicWebApiContext _context;

    public GetByIdForUpdateHandler(NicWebApiContext context)
    {
      _context = context;
    }

    public async Task<Result<GetByIdForUpdateResult>> Handle(GetByIdForUpdateCommand command)
    {
      var patientsBase = await _context.Patients
        .AsNoTracking()
        .FirstOrDefaultAsync(x => x.Id == command.PatientId);

      if (patientsBase == null)
        return Result.Failure<GetByIdForUpdateResult>($"No such {command.PatientId} in database");

      var patients = patientsBase.StationId;

      GetByIdForUpdateResult result = new(patients);

      return Result.Success(result);
    }
  }
}
