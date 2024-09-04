using NIC.Core.Models;


namespace NIC.Application.Commands
{
  public class AddPatientCommand
  {
    public required Patient Patient { get; set; }
  }
}
