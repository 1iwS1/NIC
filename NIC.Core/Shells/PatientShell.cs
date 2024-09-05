using NIC.Core.Enums;
using NIC.Core.ValueObjects;


namespace NIC.Core.Shells
{
  public record PatientShell(
    Guid Id,
    FullName FullName,
    string Address,
    DateTime Birthday,
    PersonSex Sex,
    Guid StationId
    );
}
