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
        public string nome { get; set; }
        [StringLength(30)]
        public string nacionalidade { get; set; }

        public Autores() { }
    }
}
