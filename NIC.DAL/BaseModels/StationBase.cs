namespace NIC.DAL.BaseModels;

public partial class StationBase
{
  public Guid Id { get; set; }

  public int Number { get; set; }

  public virtual ICollection<DoctorBase> Doctors { get; set; } = new List<DoctorBase>();

  public virtual ICollection<PatientBase> Patients { get; set; } = new List<PatientBase>();
}
