using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class UniversidadContext : DbContext
    {
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<Seccion> Secciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-S56NVPD;" +
                    "Database=Universidad_Salamanca;" +
                    "Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(estudiante =>
            {
                estudiante.HasKey(e => e.Cedula);

                estudiante.HasOne(e => e.Carrera).WithMany(c => c.Estudiantes);

                estudiante.HasMany(e => e.Secciones).WithMany(s => s.Estudiantes);

                estudiante.Property(e => e.Estatus).IsRequired(true);
            });

            modelBuilder.Entity<Carrera>(carrera =>
            {
                carrera.HasKey(c => c.Id);

                carrera.HasMany(c => c.Estudiantes).WithOne(e => e.Carrera);

                carrera.HasMany(c => c.Asignaturas).WithMany(a => a.Carreras);

                carrera.Property(c => c.Estatus).IsRequired(true);
            });

            modelBuilder.Entity<Asignatura>(asignatura =>
            {
                asignatura.HasKey(a => a.Id);

                asignatura.HasMany(a => a.Carreras).WithMany(c => c.Asignaturas);

                asignatura.HasMany(a => a.Secciones).WithOne(s => s.Asignatura);

                asignatura.Property(a => a.Estatus).IsRequired(true);
            });

            modelBuilder.Entity<Seccion>(seccion =>
            {
                seccion.HasKey(s => s.Id);

                seccion.HasOne(s => s.Asignatura).WithMany(a => a.Secciones);

                seccion.HasMany(s => s.Estudiantes).WithMany(e => e.Secciones);

                seccion.Property(s => s.Estatus).IsRequired(true);
            });
        }
    }
}
