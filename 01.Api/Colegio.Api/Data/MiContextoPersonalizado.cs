using System;
using System.Collections.Generic;
using Colegio.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Colegio.Api.Data;

public partial class MiContextoPersonalizado : DbContext
{
    public MiContextoPersonalizado()
    {
    }

    public MiContextoPersonalizado(DbContextOptions<MiContextoPersonalizado> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=COLEGIO;User ID=sa;Password=continental;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__menu__3213E83F2418D7E4");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__persona__3213E83F4733E260");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rol__3213E83F40D76554");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usuario__3213E83F557D5C96");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK__usuario__id_pers__2A4B4B5E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
