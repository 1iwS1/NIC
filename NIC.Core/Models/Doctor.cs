using CSharpFunctionalExtensions;

using NIC.Core.Shells;
using NIC.Core.ValueObjects;


namespace NIC.Core.Models
{
  public class Doctor
  {
    private Doctor(DoctorShell shell)
    {
      FullName = shell.FullName;
      Cabinet = shell.CabinetId;
      Specialization = shell.SpecializationId;
      Station = shell.StationId;
    }

    public Guid Id { get; }
    public FullName FullName { get; }
    public Guid Cabinet { get; }
    public Guid Specialization { get; }
    public Guid? Station { get; }

    public static Result<Doctor> Create(DoctorShell shell)
    {
      Doctor doctor = new(shell);

      return Result.Success(doctor);
    }
  }
}
