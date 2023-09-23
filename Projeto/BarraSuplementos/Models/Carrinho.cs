using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Carrinho")]
public class Carrinho
{
    [Key]
    public int Id { get; set; }
    
    public DateTime Data { get; set; }

    // [Column(DataType("decimal(7,2)"))]
    public decimal Valor { get; set; }

    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Cliente Cliente { get; set; }
}
