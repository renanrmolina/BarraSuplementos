using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Marca")]
public class Marca
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome da marca")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [(ErrorMessage = "Informe a descrição da marca")]
    [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }
}
