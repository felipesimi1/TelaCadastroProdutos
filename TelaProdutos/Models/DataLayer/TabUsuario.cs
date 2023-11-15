using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;

[Table("Tab_Usuarios")]
public partial class TabUsuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(255)]
    public string Usuario { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    public bool Administrador { get; set; }

    [StringLength(255)]
    public string? Senha { get; set; }

    public int? IdCargo { get; set; }

    [ForeignKey("IdCargo")]
    [InverseProperty("TabUsuarios")]
    public virtual Cargo? IdCargoNavigation { get; set; }
}
