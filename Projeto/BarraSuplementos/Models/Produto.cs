using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BarraSuplementos.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do produto")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Informe a descrição do produto")]
    [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }

    [Display(Name = "É lançamento?")]
    [Required(ErrorMessage = "Informe o lançamento")]
    public bool Lancamento { get; set; } = false;
    
    [Display(Name = "Quantidade em estoque")]
    [Required(ErrorMessage = "Informe a quantidade em estoque")]
    public int QntdEstoque { get; set; }

    [Column(TypeName = "decimal(8,2)")]
    [Display(Name = "Valor atual")]
    [Required(ErrorMessage = "Informe o valor atual")]
    public decimal ValorAtual { get; set; }

    [Column(TypeName = "decimal(8,2)")]
    [Display(Name = "Valor com desconto")]
    [Required(ErrorMessage = "Informe o valor com desconto")]
    public decimal ValorDesconto { get; set; }

    [StringLength(300)]
    public string Imagem { get; set; }

    [Display(Name = "Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

}
