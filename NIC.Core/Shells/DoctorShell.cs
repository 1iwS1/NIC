using NIC.Core.Models;
using NIC.Core.ValueObjects;


namespace NIC.Core.Shells
{
  public record DoctorShell(
    FullName FullName,
    Cabinet Cabinet,
    Specialization Specialization,
    Station? Station
    );
}
