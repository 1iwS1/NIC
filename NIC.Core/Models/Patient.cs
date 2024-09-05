using CSharpFunctionalExtensions;

using NIC.Core.Enums;
using NIC.Core.Shells;
using NIC.Core.ValueObjects;


namespace NIC.Core.Models
{
  public class Patient
  {
    private Patient(PatientShell shell)
    {
      FullName = shell.FullName;
      Address = shell.Address;
      Birthday = shell.Birthday;
      Sex = shell.Sex;
      StationId = shell.StationId;
    }

    public Guid Id { get; }
    public FullName FullName { get; }
    public string Address { get; }
    public DateTime Birthday { get; }
    public PersonSex Sex { get; }
    public Guid StationId { get; }

    public static Result<Patient> Create(PatientShell shell)
    {
      Patient patient = new(shell);

      return Result.Success(patient);
    }
  }
}
