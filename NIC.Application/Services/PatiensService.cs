using CSharpFunctionalExtensions;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.Commands;
using NIC.Application.ServiceResults;


namespace NIC.Application.Services
{
  public class PatiensService
  {
    private readonly ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> _addCommandHandler;
    private readonly ICommandHandler<Task<Result<DeletePatientResult>>, DeletePatientCommand> _deleteCommandHandler;

    public PatiensService(
      ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> addCommandHandler,
      ICommandHandler<Task<Result<DeletePatientResult>>, DeletePatientCommand> deleteCommandHandler
      )
    {
      _addCommandHandler = addCommandHandler;
      _deleteCommandHandler = deleteCommandHandler;
    }

    public async Task<Result<AddPatientResult>> CreatePatient(AddPatientCommand command)
    {
      return await _addCommandHandler.Handle(command);
    }

    public async Task<Result<DeletePatientResult>> DeletePatient(DeletePatientCommand command)
    {
      return await _deleteCommandHandler.Handle(command);
    }
  }
}
