using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Objetivo")]
public class Objetivo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do objetivo")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }
}
