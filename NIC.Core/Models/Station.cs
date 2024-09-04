using CSharpFunctionalExtensions;

using NIC.Core.Shells;


namespace NIC.Core.Models
{
  public class Station
  {
    private Station(StationShell shell)
    {
      Id = shell.id;
      Number = shell.Number;
    }

    public Guid Id { get; }
    public int Number { get; }

    public static Result<Station> Create(StationShell shell)
    {
      Station newStation = new(shell);

      return Result.Success(newStation);
    }
  }
}
