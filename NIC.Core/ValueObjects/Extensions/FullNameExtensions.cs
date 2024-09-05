namespace NIC.Core.ValueObjects.Extensions
{
  public static class FullNameExtensions
  {
    public static string ConvertToString(this FullName value)
    {
      return value.Surname + " " + value.Name + " " + value.Patronymic;
    }

    public static FullName ConvertToVO(this string value)
    {
      string[] initials = value.Split(' ');

      return FullName.Create(initials[0], initials[1], initials[2]).Value;
    }
  }
}
