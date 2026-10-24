using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models;

public partial class ModeloParcialContext : DbContext
{
    public ModeloParcialContext()
    {
    }

    public ModeloParcialContext(DbContextOptions<ModeloParcialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tareas> Tareas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(ConectionStringHelper.getConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tareas>(entity =>
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
