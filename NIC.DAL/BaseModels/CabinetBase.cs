namespace NIC.DAL.BaseModels;

public partial class CabinetBase
{
  public Guid Id { get; set; }

  public int? Number { get; set; }

  public virtual ICollection<DoctorBase> Doctors { get; set; } = new List<DoctorBase>();
}
