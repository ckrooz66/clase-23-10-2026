using System;
using System.Collections.Generic;
using ENTITIES.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models;

public partial class ModeloTareaContext : DbContext
{
    public ModeloTareaContext()
    {
    }

    public ModeloTareaContext(DbContextOptions<ModeloTareaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarea> Tareas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(ConectionStringHelper.getConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tareas__3214EC279360BC7D");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DescripcionTarea)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION_TAREA");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.FechaTarea)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_TAREA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
