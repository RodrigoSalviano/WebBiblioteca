using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Autores")]
    public class Autores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(70)]

        [Display(Name = "Nome do Autor")]
        [Required]
        public string nome { get; set; }
        [StringLength(30)]
        [Display(Name = "Nacionalidade")]
        public string nacionalidade { get; set; }

        public Autores() { }
    }
}
