using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SenaiGameCrud.Models
{
    public class Aluno
    {

        [Key]
        public int IdAluno { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira a idade")]
        public int Idade { get; set;}
        [Required(ErrorMessage = "Insira a modalidade")]
        public string Modalidade { get; set;}
        [Required(ErrorMessage = "Insira a matrícula")]
        [DisplayName("Matrícula")]
        public string Matricula  { get; set; }

      }
}
