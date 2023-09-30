using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("ProdutoObjetivo")]
public class ProdutoObjetivo
{
    [Key, Column(Order = 1)]
    [Display(Name = "Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    
    [Display(Name = "Objetivo")]
    public int ObjetivoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Objetivo Objetivo { get; set; }
}
