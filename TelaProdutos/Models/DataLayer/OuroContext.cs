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

    public virtual DbSet<TabEstoque> TabEstoques { get; set; }

    public virtual DbSet<TabEstoqueGrupo> TabEstoqueGrupo { get; set; }

    public virtual DbSet<TabEstoqueReferêncium> TabEstoqueReferência { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=OuroBase;Integrated Security=True; TrustServerCertificate = Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
