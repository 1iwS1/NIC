using CSharpFunctionalExtensions;


namespace NIC.Core.ValueObjects
{
  public class FullName : ValueObject
  {
    private const int MAX_FULLNAME_LENGHT = 255;
    public string Surname { get; }
    public string Name { get; }
    public string Patronymic { get; }

    private FullName(string surname, string name, string patronymic)
    {
      Surname = surname;
      Name = name;
      Patronymic = patronymic;
    }

    public static Result<FullName> Create(string surname, string name, string patronymic)
    {
      var totalLenght = surname.Length + name.Length + patronymic.Length;

      if (totalLenght > MAX_FULLNAME_LENGHT)
      {
        return Result.Failure<FullName>($"'{nameof(FullName)}' must be less than {MAX_FULLNAME_LENGHT}");
      }

      return new FullName(surname, name, patronymic);
    }

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
      yield return Surname;
      yield return Name;
      yield return Patronymic;
    }
  }
}
