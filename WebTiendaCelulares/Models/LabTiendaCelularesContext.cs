using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebTiendaCelulares.Models;

public partial class LabTiendaCelularesContext : DbContext
{
    public LabTiendaCelularesContext()
    {
    }

    public LabTiendaCelularesContext(DbContextOptions<LabTiendaCelularesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Celulare> Celulares { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=LabTiendaCelulares");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__3213E83FD9A82C6C");

            entity.ToTable("categorias");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Celulare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__celulare__3213E83FD7733505");

            entity.ToTable("celulares");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(6)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasPrecision(6)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("fecha_modificacion");
            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.IdColor).HasColumnName("idColor");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Celulares)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK_celulares_categorias");

            entity.HasOne(d => d.IdColorNavigation).WithMany(p => p.Celulares)
                .HasForeignKey(d => d.IdColor)
                .HasConstraintName("FK_celulares_colores");
        });

        modelBuilder.Entity<Colore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__colores__3213E83FB0CA302D");

            entity.ToTable("colores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__compras__3213E83F8AFA8E1D");

            entity.ToTable("compras");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DireccionEnvio)
                .HasColumnType("text")
                .HasColumnName("direccion_envio");
            entity.Property(e => e.FechaVenta)
                .HasPrecision(6)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("fecha_venta");
            entity.Property(e => e.IdCelular).HasColumnName("idCelular");
            entity.Property(e => e.IdUsuario)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdCelularNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdCelular)
                .HasConstraintName("FK_compras_celulares");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__compras__id_usua__4AB81AF0");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83F189C6714");

            entity.ToTable("usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
