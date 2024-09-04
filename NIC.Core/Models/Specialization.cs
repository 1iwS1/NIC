using CSharpFunctionalExtensions;

using NIC.Core.Shells;


namespace NIC.Core.Models
{
  public class Specialization
  {
    private Specialization(SpecializationShell shell)
    {
      Id = shell.Id;
      Name = shell.Name;
    }

    public Guid Id { get; }
    public string Name { get; }

    public static Result<Specialization> Create(SpecializationShell shell)
    {
      Specialization specialization = new(shell);

      return Result.Success(specialization);
    }
  }
}
