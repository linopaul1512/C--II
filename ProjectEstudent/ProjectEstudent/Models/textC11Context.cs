using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class textC11Context : DbContext
    {
        public textC11Context()
        {
        }

        public textC11Context(DbContextOptions<textC11Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignature> Asignature { get; set; }
        public virtual DbSet<AsignatureFaculty> AsignatureFaculty { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentSection> StudentSection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= DESKTOP-OHH7GRS;Database=textC#11;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignature>(entity =>
            {
                entity.HasKey(e => e.Codeasignature)
                    .HasName("PK__Asignatu__D7A8832F18AD24A2");

                entity.Property(e => e.Codeasignature)
                    .HasColumnName("codeasignature")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditunits).HasColumnName("creditunits");

                entity.Property(e => e.Hourspractice).HasColumnName("hourspractice");

                entity.Property(e => e.Nameasignature)
                    .IsRequired()
                    .HasColumnName("nameasignature")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Semester).HasColumnName("semester");

                entity.Property(e => e.Statusasignature)
                    .IsRequired()
                    .HasColumnName("statusasignature")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Theoryhours).HasColumnName("theoryhours");
            });

            modelBuilder.Entity<AsignatureFaculty>(entity =>
            {
                entity.HasKey(e => e.CodeAf)
                    .HasName("PK__Asignatu__47F88CF84C2E5D17");

                entity.ToTable("Asignature_Faculty");

                entity.Property(e => e.CodeAf)
                    .HasColumnName("codeAF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeasignature)
                    .IsRequired()
                    .HasColumnName("codeasignature")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codefaculty)
                    .IsRequired()
                    .HasColumnName("codefaculty")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeasignatureNavigation)
                    .WithMany(p => p.AsignatureFaculty)
                    .HasForeignKey(d => d.Codeasignature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asignatur__codea__6754599E");

                entity.HasOne(d => d.CodefacultyNavigation)
                    .WithMany(p => p.AsignatureFaculty)
                    .HasForeignKey(d => d.Codefaculty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asignatur__codef__68487DD7");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.Codefaculty)
                    .HasName("PK__Faculty__A6B318DC90D380F5");

                entity.Property(e => e.Codefaculty)
                    .HasColumnName("codefaculty")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Namefaculty)
                    .IsRequired()
                    .HasColumnName("namefaculty")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Professionalprofile)
                    .IsRequired()
                    .HasColumnName("professionalprofile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statusfaculty)
                    .IsRequired()
                    .HasColumnName("statusfaculty")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.Codesection)
                    .HasName("PK__Section__60DE46C2A9EAB98E");

                entity.Property(e => e.Codesection)
                    .HasColumnName("codesection")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeasignature)
                    .IsRequired()
                    .HasColumnName("codeasignature")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Quantitystudents).HasColumnName("quantitystudents");

                entity.HasOne(d => d.CodeasignatureNavigation)
                    .WithMany(p => p.Section)
                    .HasForeignKey(d => d.Codeasignature)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Section__codeasi__6383C8BA");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codefaculty)
                    .IsRequired()
                    .HasColumnName("codefaculty")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datebirth)
                    .HasColumnName("datebirth")
                    .HasColumnType("date");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nameestudent)
                    .IsRequired()
                    .HasColumnName("nameestudent")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasColumnName("phonenumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Statusestudent)
                    .IsRequired()
                    .HasColumnName("statusestudent")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodefacultyNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Codefaculty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__codefac__628FA481");
            });

            modelBuilder.Entity<StudentSection>(entity =>
            {
                entity.HasKey(e => e.CodeSs)
                    .HasName("PK__Student___47F970ACC53DF28E");

                entity.ToTable("Student_Section");

                entity.Property(e => e.CodeSs)
                    .HasColumnName("codeSS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codesection)
                    .IsRequired()
                    .HasColumnName("codesection")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodesectionNavigation)
                    .WithMany(p => p.StudentSection)
                    .HasForeignKey(d => d.Codesection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student_S__codes__656C112C");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.StudentSection)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student_Sect__Id__6477ECF3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
