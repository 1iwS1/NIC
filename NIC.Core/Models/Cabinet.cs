using CSharpFunctionalExtensions;

using NIC.Core.Shells;


namespace NIC.Core.Models
{
  public class Cabinet
  {
    public Cabinet(CabinetShell shell)
    {
      Id = shell.id;
      Number = shell.Number;
    }

    public Guid Id { get; }
    public int Number { get; }

    public static Result<Cabinet> Create(CabinetShell shell)
    {
      Cabinet cabinet = new(shell);

      return Result.Success(cabinet);
    }
  }
}
