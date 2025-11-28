using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBiblioteca.Models;

namespace WebBiblioteca.Controllers
{
    public class GerarBDController : Controller
    {
        private readonly Contexto contexto;
        public GerarBDController(Contexto context)
        {
            this.contexto = context;
        }

        public IActionResult LimparTudo()
        {
            contexto.Database.ExecuteSqlRaw("DELETE FROM Livros");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Livros', RESEED, 0)");

            contexto.Database.ExecuteSqlRaw("DELETE FROM Autores");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Autores', RESEED, 0)");

            contexto.Database.ExecuteSqlRaw("DELETE FROM Editora");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Editora', RESEED, 0)");

            return View();
        }

        public IActionResult Editora()
        {
            Editora editora1 = new Editora { nome = "Editora A" };
            Editora editora2 = new Editora { nome = "Editora B" };
            Editora editora3 = new Editora { nome = "Editora C" };
            Editora editora4 = new Editora { nome = "Editora D" };

            contexto.Editora.Add(editora1);
            contexto.Editora.Add(editora2);
            contexto.Editora.Add(editora3);
            contexto.Editora.Add(editora4);

            contexto.SaveChanges();

            return View(contexto.Editora.ToList);

        }

      
    }
}
