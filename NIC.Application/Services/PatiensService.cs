using NIC.Application.Abstractions.HandlersDAL;
using NIC.Application.Commands;
using NIC.Application.ServiceResults;


namespace NIC.Application.Services
{
  public class PatiensService
  {
    private readonly ICommandHandler<AddPatientResult, AddPatientCommand> _addCommandHandler;

    public PatiensService(
      ICommandHandler<AddPatientResult, AddPatientCommand> addCommandHandler
      )
    {
      _addCommandHandler = addCommandHandler;
    }

    public async AddPatientResult CreatePatient(AddPatientCommand command)
    {
      return await _addCommandHandler.
    }
  }
}
