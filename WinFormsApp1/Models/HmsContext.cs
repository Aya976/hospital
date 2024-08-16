using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class HmsContext : DbContext
{
    public HmsContext()
    {
    }

    public HmsContext(DbContextOptions<HmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.ToTable("doctors");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.MedicalLicenceNumber)
                .HasMaxLength(50)
                .HasColumnName("medicalLicenceNumber");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.YearOfexperience).HasColumnName("yearOFexperience");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
