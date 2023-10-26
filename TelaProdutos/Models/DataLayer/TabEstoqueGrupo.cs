using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;

[Keyless]
[Table("Tab_EstoqueGrupo")]
public class TabEstoqueGrupo
{
    [StringLength(3)]
    public string IdGrupo { get; set; } = null!;

    [StringLength(50)]
    public string? Grupo { get; set; }

}
