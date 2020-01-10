using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataSourceWebApi.Models
{
    public partial class MedicsSchedulingContext : DbContext
    {
        public MedicsSchedulingContext()
        {
        }

        public MedicsSchedulingContext(DbContextOptions<MedicsSchedulingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MedicalAppointments> MedicalAppointments { get; set; }
        public virtual DbSet<Medics> Medics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);Database=MedicsScheduling;User ID=XXX;Password=XXX;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalAppointments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactInfo).HasColumnType("ntext");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<Medics>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhotoBytes).HasColumnType("image");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
