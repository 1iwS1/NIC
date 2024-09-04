using NIC.Core.Enums;
using NIC.Core.Models;
using NIC.Core.ValueObjects;


namespace NIC.Core.Shells
{
  public record PatientShell(
    FullName FullName,
    string Address,
    DateTime Birthday,
    PersonSex Sex,
    Station Station
    );
}
