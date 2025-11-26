using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Editora")]
    public class Editora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(30)]
        [Display(Name = "Nome da Editora")]
        [Required]
        public string nome { get; set; }
        
        public Editora() { }

    }
}
