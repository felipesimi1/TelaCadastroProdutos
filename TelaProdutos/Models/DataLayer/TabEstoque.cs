using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TelaProdutos.Models.DataLayer;


[Table("Tab_Estoque")]
public class TabEstoque
{
    [StringLength(3)]
    public string? Grupo { get; set; }

    [StringLength(5)]
    public string? Referência { get; set; }

    [StringLength(50)]
    public string? Modelo { get; set; }

    [StringLength(20)]
    public string? CódigoFábrica { get; set; }

    [Column(TypeName = "money")]
    public decimal? Peso { get; set; }

    [Column(TypeName = "money")]
    public decimal? Volume { get; set; }

    [StringLength(20)]
    public string? CódigoVelho { get; set; }

    [StringLength(20)]
    public string? Localização { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCadastro { get; set; }

    [StringLength(20)]
    public string IdItem { get; set; }

    [StringLength(20)]
    public string? IdUsuário { get; set; }

    [Column(TypeName = "money")]
    public decimal? Largura { get; set; }

    [Column(TypeName = "money")]
    public decimal? Altura { get; set; }

    [StringLength(20)]
    public string? Localização2 { get; set; }

    [StringLength(200)]
    public string? Descrição { get; set; }

    [Column("cur_Comprimento", TypeName = "money")]
    public decimal? CurComprimento { get; set; }

    [Key]
    [Column("pk_int_Estoque")]
    public int PkIntEstoque { get; set; }

    [Column("cur_TemperaturaMaxima", TypeName = "money")]
    public decimal? CurTemperaturaMaxima { get; set; }

    [Column("cur_TemperaturaMinima", TypeName = "money")]
    public decimal? CurTemperaturaMinima { get; set; }

    [Column("cur_Umidade", TypeName = "money")]
    public decimal? CurUmidade { get; set; }

    [Column("bit_ProdutoObsoleto")]
    public bool BitProdutoObsoleto { get; set; }

    [Column("bit_ProdutoEmFalta")]
    public bool BitProdutoEmFalta { get; set; }
}
