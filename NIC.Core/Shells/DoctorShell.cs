using NIC.Core.ValueObjects;


namespace NIC.Core.Shells
{
  public record DoctorShell(
    FullName FullName,
    Guid CabinetId,
    Guid SpecializationId,
    Guid? StationId
    );
}
