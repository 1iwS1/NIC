using NIC.Core.Enums;
using NIC.Core.Models;
using NIC.Core.ValueObjects;


namespace NIC.Application.Contracts.Patient
{
  public record AddPatientDTO(
    FullName FullName,
    string Address,
    DateTime Birthday,
    PersonSex Sex,
    Station Station
    );
}
