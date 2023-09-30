using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome da categoria")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }
}
