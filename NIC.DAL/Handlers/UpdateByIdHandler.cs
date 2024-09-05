using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.ServiceResults;
using NIC.Application.Commands;
using NIC.Core.ValueObjects.Extensions;


namespace NIC.DAL.Handlers
{
  public class UpdateByIdHandler : ICommandHandler<Task<Result<UpdateByIdResult>>, UpdateByIdCommand>
  {
    private readonly NicWebApiContext _context;

    public UpdateByIdHandler(NicWebApiContext context)
    {
      _context = context;
    }

    public async Task<Result<UpdateByIdResult>> Handle(UpdateByIdCommand command)
    {
      await _context.Patients
        .Where(x => x.Id == command.Patient.Id)
        .ExecuteUpdateAsync(x => x
          .SetProperty(b => b.FullName, b => command.Patient.FullName.ConvertToString())
          .SetProperty(b => b.Address, b => command.Patient.Address)
          .SetProperty(b => b.Birthday, b => command.Patient.Birthday)
          .SetProperty(b => b.Sex, b => command.Patient.Sex.ToString())
          .SetProperty(b => b.StationId, b => command.Patient.StationId)
        );

      UpdateByIdResult result = new(command.Patient.Id);

      return Result.Success(result);
    }
  }
}
