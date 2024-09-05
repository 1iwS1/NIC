namespace NIC.DAL.BaseModels;

public partial class PatientBase
{
  public Guid Id { get; set; }

  public string FullName { get; set; }

  public string Address { get; set; }

  public DateTime Birthday { get; set; }

  public string Sex { get; set; }

  public Guid StationId { get; set; }

  public virtual StationBase? Station { get; set; }
}
