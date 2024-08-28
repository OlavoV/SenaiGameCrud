using System.ComponentModel.DataAnnotations;

namespace SenaiGameCrud.Models
{
    public class Professor
    {
        [Key]
        public int IdProf { get; set; }
        
        [Required(ErrorMessage = "Insira o Nome")]
        public string Nome { get; set; }
       
        [EmailAddress(ErrorMessage ="Email Inválido")]
        public string Email { get; set; }
        
        public int Idade { get; set; }
    }
}
