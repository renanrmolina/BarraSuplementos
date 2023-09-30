using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Carrinho")]
public class Carrinho
{
    [Key]
    public int Id { get; set; }
    
    public DateTime Data { get; set; }

    
    [Column(TypeName = "decimal(8,2)")]
    public decimal Valor { get; set; }

  
    [Display(Name = "Cliente")]
    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Cliente Cliente { get; set; }
}
