using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Usuario
    {
        [Key]
        public long Cpf { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        public int Idade { get; set; }
        [MaxLength(1)]
        public string Sexo { get; set; }
    }
}
