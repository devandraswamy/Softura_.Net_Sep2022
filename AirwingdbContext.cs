using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Airwing.Models
{
    public partial class AirwingdbContext : DbContext
    {
        public AirwingdbContext()
        {
        }

        public AirwingdbContext(DbContextOptions<AirwingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airwingusertb> Airwingusertbs { get; set; } = null!;
        public virtual DbSet<Flightdatatb> Flightdatatbs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DMQ8EIK\\SQLEXPRESS;Database=Airwingdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airwingusertb>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__Airwingu__CBA1B257573B6E49");

                entity.ToTable("Airwingusertb");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.ContacNumber)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(80)
                    .HasColumnName("password")
                    .IsFixedLength();

                entity.Property(e => e.Userloginid)
                    .HasMaxLength(80)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Flightdatatb>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK__Flightda__D9908D647AF16170");

                entity.ToTable("Flightdatatb");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.FlightFare)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.FlightSeats)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Flightfrom)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Flightname)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Flightto)
                    .HasMaxLength(80)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
