using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectBrainstormRental.Models
{
    public partial class textC9Context : DbContext
    {
        public textC9Context()
        {
        }

        public textC9Context(DbContextOptions<textC9Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BrainEnhancers> BrainEnhancers { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Rental> Rental { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OHH7GRS;Database=textC#9;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrainEnhancers>(entity =>
            {
                entity.HasKey(e => e.Serialnumber)
                    .HasName("PK__BrainEnh__E0496F88A49F68C5");

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("serialnumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Percentageimprovement).HasColumnName("percentageimprovement");

                entity.Property(e => e.Priceperhour).HasColumnName("priceperhour");

                entity.Property(e => e.Statuxbrain)
                    .HasColumnName("statuxbrain")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nameclient)
                    .HasColumnName("nameclient")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statusclient)
                    .HasColumnName("statusclient")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.HasKey(e => e.Codex)
                    .HasName("PK__Rental__920DF62EA6FA6F9E");

                entity.Property(e => e.Codex)
                    .HasColumnName("codex")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numberofhours).HasColumnName("numberofhours");

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("serialnumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Rental)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK__Rental__ID__286302EC");

                entity.HasOne(d => d.SerialnumberNavigation)
                    .WithMany(p => p.Rental)
                    .HasForeignKey(d => d.Serialnumber)
                    .HasConstraintName("FK__Rental__serialnu__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
