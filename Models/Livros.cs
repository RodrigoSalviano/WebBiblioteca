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
        public string titulo { get; set; }
        public int volume { get; set; }
        [StringLength(30)]
        public string genero { get; set; }
        public int Paginas { get; set; }
        [StringLength(10)]
        public string publicacao { get; set; }
        public int qtd { get; set; }

        public Livros() { }

        public Livros(int paginas)
        {
            Paginas=paginas;
        }

        
    }
}
