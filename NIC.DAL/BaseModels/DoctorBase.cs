namespace NIC.DAL.BaseModels;

public partial class DoctorBase
{
  public Guid Id { get; set; }

  public string FullName { get; set; }

  public Guid CabinetId { get; set; }

  public Guid SpecializationId { get; set; }

  public Guid StationId { get; set; }

  public virtual CabinetBase? Cabinet { get; set; }

  public virtual SpecializationBase? Specialization { get; set; }

  public virtual StationBase? Station { get; set; }
}
