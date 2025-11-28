using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBiblioteca.Models
{
    [Table("Livros")]
    public class Livros
    {
        internal int editora;
        internal int id_editora;
        internal int id_autor;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(120)]
        [Display(Name = "Título")]
        [Required]
        public string titulo { get; set; }

        [Display(Name = "Volume")]
        [Required]
        public int volume { get; set; }

        [StringLength(30)]
        [Display(Name = "Gênero")]
        [Required]
        public string genero { get; set; }

        [Display(Name = "Número de Páginas")]
        public int Paginas { get; set; }

        [StringLength(10)]
        public string publicacao { get; set; }

        [Display(Name = "Quantidade em Estoque")]
        [Required]
        public int qtd { get; set; }

        [Display(Name = "Autor")]
        public int AutorId { get; set; }

        [ForeignKey("AutorId")]
        public virtual Autores Autor { get; set; }
        [NotMapped]
        [Display(Name = "Lista de Autores")]
        public List<Autores> listaAutores { get; set; } = new List<Autores>();

        public Livros() {
            titulo = string.Empty;
            volume = 0;
            genero = string.Empty;
            Paginas = 0;
            publicacao = string.Empty;
            qtd = 0;
            listaAutores = new List<Autores>();
        }

        public Livros(int id, string titulo, int volume, string genero, int paginas, string publicacao, int qtd)
        {
            this.id = id;
            this.titulo = titulo;
            this.volume = volume;
            this.genero = genero;
            this.Paginas = paginas;
            this.publicacao = publicacao;
            this.qtd = qtd;
            listaAutores = new List<Autores>();
        }
    }
}