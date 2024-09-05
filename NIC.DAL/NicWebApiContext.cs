using Microsoft.EntityFrameworkCore;

using NIC.DAL.BaseModels;


namespace NIC.DAL;

public partial class NicWebApiContext : DbContext
{
  public NicWebApiContext()
  {
  }

  public NicWebApiContext(DbContextOptions<NicWebApiContext> options)
      : base(options)
  {
  }

  public virtual DbSet<CabinetBase> Cabinets { get; set; }

  public virtual DbSet<DoctorBase> Doctors { get; set; }

  public virtual DbSet<PatientBase> Patients { get; set; }

  public virtual DbSet<SpecializationBase> Specializations { get; set; }

  public virtual DbSet<StationBase> Stations { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<CabinetBase>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK_Cabinets_Id");

      entity.Property(e => e.Id).ValueGeneratedNever();
    });

    modelBuilder.Entity<DoctorBase>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK_Doctors_Id");

      entity.Property(e => e.Id).ValueGeneratedNever();
      entity.Property(e => e.FullName).HasMaxLength(255);

      entity.HasOne(d => d.Cabinet).WithMany(p => p.Doctors)
              .HasForeignKey(d => d.CabinetId)
              .HasConstraintName("FK_Doctors_CabinetId");

      entity.HasOne(d => d.Specialization).WithMany(p => p.Doctors)
              .HasForeignKey(d => d.SpecializationId)
              .HasConstraintName("FK_Doctors_SpecializationId");

      entity.HasOne(d => d.Station).WithMany(p => p.Doctors)
              .HasForeignKey(d => d.StationId)
              .HasConstraintName("FK_Doctors_StationId");
    });

    modelBuilder.Entity<PatientBase>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK_Patients_Id");

      entity.Property(e => e.Id).ValueGeneratedNever();
      entity.Property(e => e.Address).HasMaxLength(255);
      entity.Property(e => e.Birthday).HasColumnType("datetime");
      entity.Property(e => e.FullName).HasMaxLength(255);
      entity.Property(e => e.Sex).HasMaxLength(50);

      entity.HasOne(d => d.Station).WithMany(p => p.Patients)
              .HasForeignKey(d => d.StationId)
              .HasConstraintName("FK_Patients_StationId");
    });

    modelBuilder.Entity<SpecializationBase>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK_Specializations_Id");

      entity.Property(e => e.Id).ValueGeneratedNever();
      entity.Property(e => e.Name).HasMaxLength(255);
    });

    modelBuilder.Entity<StationBase>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK_Stations_Id");

      entity.Property(e => e.Id).ValueGeneratedNever();
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
