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
        [Required]
        public string nacionalidade { get; set; }

        [Display(Name = "Editora")]
        public int editoraID { get; set; }
        [ForeignKey("editoraID")]
        public virtual Editora Editora { get; set; }

        [Display(Name = "Lista de Editoras")]
        [NotMapped]
        public List<Editora> listaEditora { get; set; } = new List<Editora>();

        public Autores() {
            nome = string.Empty;
            nacionalidade = string.Empty;
            listaEditora = new List<Editora>();
        }

        public Autores(int id, string nome, string nacionalidade)
        {
            this.id = id;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            listaEditora = new List<Editora>();
        }
    }
}
