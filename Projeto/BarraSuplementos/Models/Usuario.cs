using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do usuário")]
    [StringLength(20, ErrorMessage = "O usuário deve possuir no máximo 20 caracteres")]
    public string Nome { get; set;}

    [Required(ErrorMessage = "Informe a senha")]
    [StringLength(8, ErrorMessage = "A senha deve possuir no máximo 8 caracteres")]
    public string Senha { get; set;}

    
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Informe o email do Usuário")]
    [StringLength(60, ErrorMessage = "O email deve possuir no máximo 60 caracteres")]
    public string Email { get; set;}
}
