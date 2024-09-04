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
      Cabinet = shell.Cabinet;
      Specialization = shell.Specialization;
      Station = shell.Station;
    }

    public Guid Id { get; }
    public FullName FullName { get; }
    public Cabinet Cabinet { get; }
    public Specialization Specialization { get; }
    public Station? Station { get; }

    public static Result<Doctor> Create(DoctorShell shell)
    {
      Doctor doctor = new(shell);

      return Result.Success(doctor);
    }
  }
}
