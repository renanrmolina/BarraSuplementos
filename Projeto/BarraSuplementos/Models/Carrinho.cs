using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Carrinho")]
public class Carrinho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public DateTime Data { get; set; }
    
    [Column(TypeName = "decimal(8,2)")]
    public decimal Valor { get; set; }
  
    [Display(Name = "Cliente")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    public ICollection<CarrinhoProduto> Produtos { get; set; }
}
