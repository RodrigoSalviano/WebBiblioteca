using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int id { get; set; }
        [StringLength(100)]
        [Required]
        public string nome { get; set; }
        [StringLength(120)]
        [Required]
        public string email { get; set; }
        [StringLength(100)]
        [Required]
        public string senha { get; set; }
        [Required]
        public string acesso { get; set; }

        public Usuario() { }
    }
}
