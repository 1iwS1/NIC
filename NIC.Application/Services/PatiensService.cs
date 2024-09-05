using CSharpFunctionalExtensions;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.Commands;
using NIC.Application.ServiceResults;


namespace NIC.Application.Services
{
  public class PatiensService
  {
    private readonly ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> _addCommandHandler;

    public PatiensService(
      ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> addCommandHandler
      )
    {
      _addCommandHandler = addCommandHandler;
    }

    public async Task<Result<AddPatientResult>> CreatePatient(AddPatientCommand command)
    {
      return await _addCommandHandler.Handle(command);
    }
  }
}
