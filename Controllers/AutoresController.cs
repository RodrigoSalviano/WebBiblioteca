using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBiblioteca.Models;

namespace WebBiblioteca.Controllers
{
    public class AutoresController : Controller
    {
        private readonly Contexto _context;

        public AutoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Autores
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Autores.Include(a => a.Editora);
            return View(await contexto.ToListAsync());
        }

        // GET: Autores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autores = await _context.Autores
                .Include(a => a.Editora)
                .FirstOrDefaultAsync(m => m.id == id);
            if (autores == null)
            {
                return NotFound();
            }

            return View(autores);
        }

        // GET: Autores/Create
        public IActionResult Create()
        {
            ViewData["editoraID"] = new SelectList(_context.Editora, "id", "nome");
            return View();
        }

        // POST: Autores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,nacionalidade,editoraID")] Autores autores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["editoraID"] = new SelectList(_context.Editora, "id", "nome", autores.editoraID);
            return View(autores);
        }

        // GET: Autores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autores = await _context.Autores.FindAsync(id);
            if (autores == null)
            {
                return NotFound();
            }
            ViewData["editoraID"] = new SelectList(_context.Editora, "id", "nome", autores.editoraID);
            return View(autores);
        }

        // POST: Autores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,nacionalidade,editoraID")] Autores autores)
        {
            if (id != autores.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoresExists(autores.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["editoraID"] = new SelectList(_context.Editora, "id", "nome", autores.editoraID);
            return View(autores);
        }

        // GET: Autores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autores = await _context.Autores
                .Include(a => a.Editora)
                .FirstOrDefaultAsync(m => m.id == id);
            if (autores == null)
            {
                return NotFound();
            }

            return View(autores);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autores = await _context.Autores.FindAsync(id);
            if (autores != null)
            {
                _context.Autores.Remove(autores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoresExists(int id)
        {
            return _context.Autores.Any(e => e.id == id);
        }
    }
}
