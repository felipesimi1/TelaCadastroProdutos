using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;

[Keyless]
[Table("Tab_EstoqueReferência")]
public class TabEstoqueReferêncium
{
    [StringLength(3)]
    public string IdGrupo { get; set; } = null!;

    [StringLength(5)]
    public string IdReferência { get; set; } = null!;

    [StringLength(50)]
    public string? Referência { get; set; }
}
