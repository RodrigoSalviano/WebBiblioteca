using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public enum NivelAcesso
        {
            Administrador,
            UsuarioComum
        }

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
        
        [Display(Name = "Nível de Acesso")]
        [Required]
        public NivelAcesso acesso { get; set; }

        public Usuario() { }
    }
}
