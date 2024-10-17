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
    public class LibrosController : Controller
    {
        private readonly WebBibliotecaContext _context;

        public LibrosController(WebBibliotecaContext context)
        {
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index()
        {
            var webBibliotecaContext = _context.Libros.Include(l => l.IdAutorNavigation);
            return View(await webBibliotecaContext.ToListAsync());
        }

        // GET: Libros/Create
        public IActionResult Create()
        {
            ViewData["IdAutor"] = new SelectList(_context.Autores, "AutorId", "Nombre");
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,IdAutor")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(libro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAutor"] = new SelectList(_context.Autores, "AutorId", "AutorId", libro.IdAutor);
            return View(libro);
        }
        private bool LibroExists(int id)
        {
            return _context.Libros.Any(e => e.Id == id);
        }
    }
}
