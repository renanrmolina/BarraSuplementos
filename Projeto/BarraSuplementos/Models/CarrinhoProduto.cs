using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("ProdutoCarrinho")]
public class ProdutoCarrinho
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public int SaborId { get; set; }
    [ForeignKey("ProdutoId")]
    public Sabor Sabor { get; set; }

    [Key, Column(Order = 3)]
    public int CarrinhoId { get; set; }
    [ForeignKey("CarrinhoId")]
    public Carrinho Carrinho { get; set; }
}
