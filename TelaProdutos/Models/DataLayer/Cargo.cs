using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;

public partial class Cargo
{
    [Key]
    public int IdCargo { get; set; }

    [Column("Cargo")]
    [StringLength(40)]
    public string? Cargo1 { get; set; }

    [InverseProperty("IdCargoNavigation")]
    public virtual ICollection<TabUsuario> TabUsuarios { get; set; } = new List<TabUsuario>();
}
