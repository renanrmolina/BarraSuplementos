using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("CarrinhoProduto")]
public class CarrinhoProduto
{
    [Key, Column(Order = 1)]
    public int Id { get; set; }

    [Key, Column(Order = 2)]
    [Display(Name = "Carrinho")]
    public int CarrinhoId { get; set; }
    [ForeignKey("CarrinhoId")]
    public Carrinho Carrinho { get; set; }

    [Required]
    [Display(Name = "Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Display(Name = "Sabor")]
    public int? SaborId { get; set; }
    [ForeignKey("SaborId")]
    public Sabor Sabor { get; set; }

    [Display(Name = "Quantidade")]
    [Required(ErrorMessage = "Informe a quantidade")]
    public int Qtd { get; set; }
}
