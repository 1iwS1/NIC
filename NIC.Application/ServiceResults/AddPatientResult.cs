using CSharpFunctionalExtensions;


namespace NIC.Application.ServiceResults
{
  public record AddPatientResult(
    Task<Result<Guid>> Result
    );
}
