using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(120)]
        [Display(Name = "Título")]
        [Required]
        public string titulo { get; set; }
        [StringLength(3)]
        [Display(Name = "Volume")]
        [Required]
        public int volume { get; set; }
        [StringLength(30)]
        [Display(Name = "Gênero")]
        [Required]
        public string genero { get; set; }
        [Display(Name = "Número de Páginas")]
        [Required]
        public int Paginas { get; set; }
        [StringLength(10)]
        public string publicacao { get; set; }
        [Display(Name = "Quantidade em Estoque")]
        [Required]
        public int qtd { get; set; }

        public Livros() { }

        public Livros(int paginas)
        {
            Paginas=paginas;
        }

        
    }
}
