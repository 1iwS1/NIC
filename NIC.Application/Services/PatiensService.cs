using CSharpFunctionalExtensions;

using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.Commands;
using NIC.Application.Queries;
using NIC.Application.ServiceResults;


namespace NIC.Application.Services
{
  public class PatiensService
  {
    private readonly ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> _addCommandHandler;
    private readonly ICommandHandler<Task<Result<DeletePatientResult>>, DeletePatientCommand> _deleteCommandHandler;
    private readonly ICommandHandler<Task<Result<UpdateByIdResult>>, UpdateByIdCommand> _updateCommandHandler;

    private readonly IQueryHandler<Task<Result<GetByIdForUpdateResult>>, GetByIdForUpdateCommand> _getByIdQueryHandler;

    public PatiensService(
      ICommandHandler<Task<Result<AddPatientResult>>, AddPatientCommand> addCommandHandler,
      ICommandHandler<Task<Result<DeletePatientResult>>, DeletePatientCommand> deleteCommandHandler,
      ICommandHandler<Task<Result<UpdateByIdResult>>, UpdateByIdCommand> updateCommandHandler,
      IQueryHandler<Task<Result<GetByIdForUpdateResult>>, GetByIdForUpdateCommand> getByIdQueryHandler
      )
    {
      _addCommandHandler = addCommandHandler;
      _deleteCommandHandler = deleteCommandHandler;
      _updateCommandHandler = updateCommandHandler;

      _getByIdQueryHandler = getByIdQueryHandler;
    }

    public async Task<Result<AddPatientResult>> CreatePatient(AddPatientCommand command)
    {
      return await _addCommandHandler.Handle(command);
    }

    public async Task<Result<DeletePatientResult>> DeletePatient(DeletePatientCommand command)
    {
      return await _deleteCommandHandler.Handle(command);
    }

    public async Task<Result<GetByIdForUpdateResult>> GetByIdForUpdate(GetByIdForUpdateCommand command)
    {
      return await _getByIdQueryHandler.Handle(command);
    }

    public async Task<Result<UpdateByIdResult>> UpdateById(UpdateByIdCommand command)
    {
      return await _updateCommandHandler.Handle(command);
    }
  }
}
