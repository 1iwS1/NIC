namespace NIC.DAL.BaseModels;

public partial class SpecializationBase
{
  public Guid Id { get; set; }

  public string Name { get; set; }

  public virtual ICollection<DoctorBase> Doctors { get; set; } = new List<DoctorBase>();
}
