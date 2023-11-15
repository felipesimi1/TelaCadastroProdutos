using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;

public partial class OuroContext : DbContext
{
    public OuroContext()
    {
    }

    public OuroContext(DbContextOptions<OuroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<TabEstoque> TabEstoques { get; set; }

    public virtual DbSet<TabEstoqueGrupo> TabEstoqueGrupo { get; set; }

    public virtual DbSet<TabEstoqueReferêncium> TabEstoqueReferência { get; set; }

    public virtual DbSet<TabUsuario> TabUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=OuroBase;Integrated Security=True; TrustServerCertificate = Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__Cargos__6C9856257BE4C2EB");
        });

        modelBuilder.Entity<TabEstoque>(entity =>
        {
            entity.HasKey(e => e.PkIntEstoque).HasName("PK__Tab_Esto__E3CA12666FCCFDF3");
        });

        modelBuilder.Entity<TabUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Tab_Usua__5B65BF97587CA00F");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.TabUsuarios).HasConstraintName("FK__Tab_Usuar__IdCar__5EBF139D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
