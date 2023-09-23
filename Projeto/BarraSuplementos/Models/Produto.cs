using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BarraSuplementos.Models;

[Table("Produto")]
public class Produto
{
    [Key, Column(Order = 1)]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Lancamento { get; set; }
    public int QntdEstoque { get; set; }
    public decimal ValorAtual { get; set; }
    public decimal ValorDesconto { get; set; }
    public string Imagem { get; set; }

    [Key, Column(Order = 2)]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

}
