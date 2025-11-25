namespace WebBiblioteca.Models
{
    public class Livros
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public int Paginas { get; set; }

        public Livros(int paginas)
        {
            Paginas=paginas;
        }

        public int qtd { get; set; }
    }
}
