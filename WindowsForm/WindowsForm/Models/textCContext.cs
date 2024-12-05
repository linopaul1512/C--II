using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsForm.Models
{
    public partial class textCContext : DbContext
    {
        public textCContext()
        {
        }

        public textCContext(DbContextOptions<textCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Civilianvillain> Civilianvillain { get; set; }
        public virtual DbSet<Spiderman> Spiderman { get; set; }
        public virtual DbSet<Universe> Universe { get; set; }
        public virtual DbSet<Villain> Villain { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OHH7GRS;Database=textC#;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Civilianvillain>(entity =>
            {
                entity.HasKey(e => e.Codex)
                    .HasName("PK__Civilian__920DF62E19C86F3B");

                entity.Property(e => e.Codex)
                    .HasColumnName("codex")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Civilianname)
                    .HasColumnName("civilianname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codeuniverse)
                    .HasColumnName("codeuniverse")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codevillain)
                    .HasColumnName("codevillain")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Statusx)
                    .HasColumnName("statusx")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodeuniverseNavigation)
                    .WithMany(p => p.Civilianvillain)
                    .HasForeignKey(d => d.Codeuniverse)
                    .HasConstraintName("FK__Civilianv__codeu__44FF419A");

                entity.HasOne(d => d.Codeuniverse1)
                    .WithMany(p => p.Civilianvillain)
                    .HasForeignKey(d => d.Codeuniverse)
                    .HasConstraintName("FK__Civilianv__codeu__398D8EEE");
            });

            modelBuilder.Entity<Spiderman>(entity =>
            {
                entity.HasKey(e => e.Codex)
                    .HasName("PK__Spiderma__920DF62E76878AE0");

                entity.Property(e => e.Codex)
                    .HasColumnName("codex")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeuniverse)
                    .HasColumnName("codeuniverse")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colors)
                    .HasColumnName("colors")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statusx)
                    .HasColumnName("statusx")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Superheroname)
                    .HasColumnName("superheroname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Superpowers)
                    .HasColumnName("superpowers")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodexNavigation)
                    .WithOne(p => p.Spiderman)
                    .HasForeignKey<Spiderman>(d => d.Codex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Spiderman__codex__2C3393D0");
            });

            modelBuilder.Entity<Universe>(entity =>
            {
                entity.HasKey(e => e.Codex)
                    .HasName("PK__Universe__920DF62E40F602C4");

                entity.Property(e => e.Codex)
                    .HasColumnName("codex")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Locationx)
                    .HasColumnName("locationx")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namex)
                    .HasColumnName("namex")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantityx).HasColumnName("quantityx");

                entity.Property(e => e.Statex)
                    .HasColumnName("statex")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Villain>(entity =>
            {
                entity.HasKey(e => e.Codex)
                    .HasName("PK__Villain__920DF62E51EB2D86");

                entity.Property(e => e.Codex)
                    .HasColumnName("codex")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dangerousness).HasColumnName("dangerousness");

                entity.Property(e => e.Ocupation)
                    .HasColumnName("ocupation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statusx)
                    .HasColumnName("statusx")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Superheroname)
                    .HasColumnName("superheroname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
