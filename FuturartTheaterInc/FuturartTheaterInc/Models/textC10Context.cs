using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FuturartTheaterInc.Models
{
    public partial class textC10Context : DbContext
    {
        public textC10Context()
        {
        }

        public textC10Context(DbContextOptions<textC10Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TheaterPlays> TheaterPlays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= DESKTOP-OHH7GRS;Database=textC#10;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TheaterPlays>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__TheaterP__357D4CF8367950D9");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Authorsname)
                    .IsRequired()
                    .HasColumnName("authorsname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmodification)
                    .HasColumnName("lastmodification")
                    .HasColumnType("date");

                entity.Property(e => e.Nametp)
                    .IsRequired()
                    .HasColumnName("nametp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Releasedate)
                    .HasColumnName("releasedate")
                    .HasColumnType("date");

                entity.Property(e => e.Statex)
                    .IsRequired()
                    .HasColumnName("statex")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
