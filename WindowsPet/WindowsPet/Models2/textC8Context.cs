using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class textC8Context : DbContext
    {
        public textC8Context()
        {
        }

        public textC8Context(DbContextOptions<textC8Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Gift> Gift { get; set; }
        public virtual DbSet<Gossip> Gossip { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Subtaks> Subtaks { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskMember> TaskMember { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OHH7GRS;Database= textC#8;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gift>(entity =>
            {
                entity.HasKey(e => e.Codegift)
                    .HasName("PK__Gift__1CC36C62A5626DD5");

                entity.Property(e => e.Codegift)
                    .HasColumnName("codegift")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dategif)
                    .HasColumnName("dategif")
                    .HasColumnType("date");

                entity.Property(e => e.Descriptiongif)
                    .IsRequired()
                    .HasColumnName("descriptiongif")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statusgif)
                    .IsRequired()
                    .HasColumnName("statusgif")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gossip>(entity =>
            {
                entity.HasKey(e => e.Codegossip)
                    .HasName("PK__Gossip__DC284E48D616A7C1");

                entity.Property(e => e.Codegossip)
                    .HasColumnName("codegossip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptiongossip)
                    .IsRequired()
                    .HasColumnName("descriptiongossip")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idmember)
                    .IsRequired()
                    .HasColumnName("IDmember")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Statusgossip)
                    .IsRequired()
                    .HasColumnName("statusgossip")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdmemberNavigation)
                    .WithMany(p => p.Gossip)
                    .HasForeignKey(d => d.Idmember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Gossip__IDmember__6477ECF3");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codegift)
                    .IsRequired()
                    .HasColumnName("codegift")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datebirth)
                    .HasColumnName("datebirth")
                    .HasColumnType("date");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Namemember)
                    .IsRequired()
                    .HasColumnName("namemember")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Roomnumber)
                    .IsRequired()
                    .HasColumnName("roomnumber")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Statusmember)
                    .IsRequired()
                    .HasColumnName("statusmember")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodegiftNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.Codegift)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Member__codegift__656C112C");
            });

            modelBuilder.Entity<Subtaks>(entity =>
            {
                entity.HasKey(e => e.Codesubtask)
                    .HasName("PK__Subtaks__52203F0278B788DC");

                entity.Property(e => e.Codesubtask)
                    .HasColumnName("codesubtask")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptionsubtaks)
                    .IsRequired()
                    .HasColumnName("descriptionsubtaks")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statussubtaks)
                    .IsRequired()
                    .HasColumnName("statussubtaks")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.Codetask)
                    .HasName("PK__Task__D80A12DF6B09DFE6");

                entity.Property(e => e.Codetask)
                    .HasColumnName("codetask")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codesubtask)
                    .IsRequired()
                    .HasColumnName("codesubtask")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descriptiontaks)
                    .IsRequired()
                    .HasColumnName("descriptiontaks")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statustaks)
                    .IsRequired()
                    .HasColumnName("statustaks")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ubication)
                    .IsRequired()
                    .HasColumnName("ubication")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodesubtaskNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.Codesubtask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Task__codesubtas__571DF1D5");
            });

            modelBuilder.Entity<TaskMember>(entity =>
            {
                entity.HasKey(e => e.Codetaskmember)
                    .HasName("PK__TaskMemb__D10312BE1E907CC2");

                entity.Property(e => e.Codetaskmember)
                    .HasColumnName("codetaskmember")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codetask)
                    .IsRequired()
                    .HasColumnName("codetask")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datetask)
                    .HasColumnName("datetask")
                    .HasColumnType("date");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Statustk)
                    .IsRequired()
                    .HasColumnName("statustk")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodetaskNavigation)
                    .WithMany(p => p.TaskMember)
                    .HasForeignKey(d => d.Codetask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TaskMembe__codet__6383C8BA");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TaskMember)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TaskMember__ID__628FA481");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
