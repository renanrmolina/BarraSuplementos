using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarraSuplementos.Models;

[Table("Cliente")]
public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome do Cliente")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set;}

    [Required(ErrorMessage = "Informe o email do Cliente")]
    [StringLength(60, ErrorMessage = "O email deve possuir no máximo 60 caracteres")]
    public string Email { get; set;}

    [Required(ErrorMessage = "Informe o CPF do Cliente")]
    [StringLength(12, ErrorMessage = "O CPF deve possuir no máximo 12 caracteres")]
    public int CPF { get; set;}

    [Required(ErrorMessage = "Informe a data de nascimento do Cliente")]
    [StringLength(10, ErrorMessage = "A data de nascimento deve possuir no máximo 10 caracteres")]
    public string DataNascimento { get; set;} //verificar se é string

    [Required(ErrorMessage = "Informe o celular do Cliente")]
    [StringLength(12, ErrorMessage = "O celular deve possuir no máximo 12 caracteres")]
    public int Celular { get; set;}

    [Required(ErrorMessage = "Informe o gênero do Cliente")]
    [StringLength(15, ErrorMessage = "O gênero deve possuir no máximo 15 caracteres")]
    public string Genero { get; set;}
}
