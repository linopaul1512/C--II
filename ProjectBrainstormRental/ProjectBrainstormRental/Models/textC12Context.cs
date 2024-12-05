using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectBrainstormRental.Models2
{
    public partial class textC12Context : DbContext
    {
        public textC12Context()
        {
        }

        public textC12Context(DbContextOptions<textC12Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<MaterialsAppointment> MaterialsAppointment { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceAppointment> ServiceAppointment { get; set; }
        public virtual DbSet<Userx> Userx { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= DESKTOP-OHH7GRS;Database=textC#12;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Codeappointment)
                    .HasName("PK__Appointm__B595422C6877E73E");

                entity.Property(e => e.Codeappointment)
                    .HasColumnName("codeappointment")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeservice)
                    .IsRequired()
                    .HasColumnName("codeservice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idclient)
                    .IsRequired()
                    .HasColumnName("IDclient")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idworker)
                    .IsRequired()
                    .HasColumnName("IDworker")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Instalationdate)
                    .HasColumnName("instalationdate")
                    .HasColumnType("date");

                entity.Property(e => e.Statusappoinment)
                    .IsRequired()
                    .HasColumnName("statusappoinment")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdclientNavigation)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.Idclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__IDcli__0C85DE4D");

                entity.HasOne(d => d.IdworkerNavigation)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.Idworker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__IDwor__0B91BA14");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Idclient)
                    .HasName("PK__Client__E1A0F27EDD882A32");

                entity.Property(e => e.Idclient)
                    .HasColumnName("IDclient")
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

                entity.Property(e => e.Nameclient)
                    .IsRequired()
                    .HasColumnName("nameclient")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasColumnName("phonenumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statusclient)
                    .IsRequired()
                    .HasColumnName("statusclient")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Codeinvoice)
                    .HasName("PK__Invoice__80DE8E07481D9B0D");

                entity.Property(e => e.Codeinvoice)
                    .HasColumnName("codeinvoice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeappointment)
                    .IsRequired()
                    .HasColumnName("codeappointment")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dateinvoice)
                    .HasColumnName("dateinvoice")
                    .HasColumnType("date");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Saleprice).HasColumnName("saleprice");

                entity.Property(e => e.Statusinvoice)
                    .IsRequired()
                    .HasColumnName("statusinvoice")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodeappointmentNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.Codeappointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Invoice__codeapp__0D7A0286");
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasKey(e => e.Codematerials)
                    .HasName("PK__Material__F231860E7ABF1C23");

                entity.Property(e => e.Codematerials)
                    .HasColumnName("codematerials")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptionservice)
                    .IsRequired()
                    .HasColumnName("descriptionservice")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Puccharseprice).HasColumnName("puccharseprice");

                entity.Property(e => e.Sale).HasColumnName("sale");

                entity.Property(e => e.Statusmaterials)
                    .IsRequired()
                    .HasColumnName("statusmaterials")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MaterialsAppointment>(entity =>
            {
                entity.HasKey(e => e.CodeMa)
                    .HasName("PK__Material__47F92E4672E3344C");

                entity.ToTable("Materials_Appointment");

                entity.Property(e => e.CodeMa)
                    .HasColumnName("codeMA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeappointment)
                    .IsRequired()
                    .HasColumnName("codeappointment")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codematerials)
                    .IsRequired()
                    .HasColumnName("codematerials")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeappointmentNavigation)
                    .WithMany(p => p.MaterialsAppointment)
                    .HasForeignKey(d => d.Codeappointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materials__codea__0A9D95DB");

                entity.HasOne(d => d.CodematerialsNavigation)
                    .WithMany(p => p.MaterialsAppointment)
                    .HasForeignKey(d => d.Codematerials)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materials__codem__09A971A2");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Coderole)
                    .HasName("PK__Role__CD6A470EEF4B4AC7");

                entity.Property(e => e.Coderole)
                    .HasColumnName("coderole")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptionrole)
                    .IsRequired()
                    .HasColumnName("descriptionrole")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statusrole)
                    .IsRequired()
                    .HasColumnName("statusrole")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Codeservice)
                    .HasName("PK__Service__9BF30041C6642746");

                entity.Property(e => e.Codeservice)
                    .HasColumnName("codeservice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptionservice)
                    .IsRequired()
                    .HasColumnName("descriptionservice")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Statuservice)
                    .IsRequired()
                    .HasColumnName("statuservice")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ServiceAppointment>(entity =>
            {
                entity.HasKey(e => e.CodeSa)
                    .HasName("PK__Service___47F9709A4A857645");

                entity.ToTable("Service_Appointment");

                entity.Property(e => e.CodeSa)
                    .HasColumnName("codeSA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeappointment)
                    .IsRequired()
                    .HasColumnName("codeappointment")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codeservice)
                    .IsRequired()
                    .HasColumnName("codeservice")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeappointmentNavigation)
                    .WithMany(p => p.ServiceAppointment)
                    .HasForeignKey(d => d.Codeappointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service_A__codea__05D8E0BE");

                entity.HasOne(d => d.CodeserviceNavigation)
                    .WithMany(p => p.ServiceAppointment)
                    .HasForeignKey(d => d.Codeservice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service_A__codes__04E4BC85");
            });

            modelBuilder.Entity<Userx>(entity =>
            {
                entity.HasKey(e => e.Codeuser)
                    .HasName("PK__Userx__85AB51E5A93605F4");

                entity.Property(e => e.Codeuser)
                    .HasColumnName("codeuser")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Coderole)
                    .IsRequired()
                    .HasColumnName("coderole")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Passworduser)
                    .IsRequired()
                    .HasColumnName("passworduser")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Personalname)
                    .IsRequired()
                    .HasColumnName("personalname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statususer)
                    .IsRequired()
                    .HasColumnName("statususer")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CoderoleNavigation)
                    .WithMany(p => p.Userx)
                    .HasForeignKey(d => d.Coderole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Userx__coderole__6EF57B66");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.Idworker)
                    .HasName("PK__Worker__9AE63C7395502879");

                entity.Property(e => e.Idworker)
                    .HasColumnName("IDworker")
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

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nameworker)
                    .IsRequired()
                    .HasColumnName("nameworker")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasColumnName("phonenumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Statusworker)
                    .IsRequired()
                    .HasColumnName("statusworker")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
