using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTiendaCelulares.Models;
using WebTiendaCelulares.ViewModels;

namespace WebTiendaCelulares.Controllers
{
    public class CelularesController : Controller
    {
        private readonly LabTiendaCelularesContext _context;

        public CelularesController(LabTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Celulares
        public async Task<IActionResult> Index()
        {
            var labTiendaCelularesContext = await _context.Celulares
                .Include(c => c.IdCategoriaNavigation)
                .Include(c => c.IdColorNavigation)
                .Select(c => new CelularViewModel
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Marca = c.Marca,
                    Modelo = c.Modelo,
                    Precio = c.Precio,
                    Descripcion = c.Descripcion,
                    NombreCategoria = c.IdCategoriaNavigation.Nombre,
                    NombreColor = c.IdColorNavigation.Nombre
                })
                .ToListAsync();
            return View(labTiendaCelularesContext);
        }

        // GET: Celulares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulares
                .Include(c => c.IdCategoriaNavigation)
                .Include(c => c.IdColorNavigation)
                .Select(c => new CelularViewModel
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Marca = c.Marca,
                    Modelo = c.Modelo,
                    Precio = c.Precio,
                    Descripcion = c.Descripcion,
                    NombreCategoria = c.IdCategoriaNavigation.Nombre,
                    NombreColor = c.IdColorNavigation.Nombre
                })
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // GET: Celulares/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre");
            ViewData["IdColor"] = new SelectList(_context.Colores, "Id", "Nombre");
            return View();
        }

        // POST: Celulares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Marca,Modelo,Precio,IdColor,IdCategoria")] Celulare celulare)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celulare);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", celulare.IdCategoria);
            ViewData["IdColor"] = new SelectList(_context.Colores, "Id", "Nombre", celulare.IdColor);
            return View(celulare);
        }

        // GET: Celulares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celulare = await _context.Celulares.FindAsync(id);
            if (celulare == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", celulare.IdCategoria);
            ViewData["IdColor"] = new SelectList(_context.Colores, "Id", "Nombre", celulare.IdColor);
            return View(celulare);
        }

        // POST: Celulares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Marca,Modelo,Precio,IdColor,IdCategoria")] Celulare celulare)
        {
            if (id != celulare.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celulare);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelulareExists(celulare.Id))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", celulare.IdCategoria);
            ViewData["IdColor"] = new SelectList(_context.Colores, "Id", "Nombre", celulare.IdColor);
            return View(celulare);
        }

        // GET: Celulares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulares
                .Include(c => c.IdCategoriaNavigation)
                .Include(c => c.IdColorNavigation)
                .Select(c => new CelularViewModel
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Marca = c.Marca,
                    Modelo = c.Modelo,
                    Precio = c.Precio,
                    Descripcion = c.Descripcion,
                    NombreCategoria = c.IdCategoriaNavigation.Nombre,
                    NombreColor = c.IdColorNavigation.Nombre
                })
                .FirstOrDefaultAsync(m => m.Id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celulare = await _context.Celulares.FindAsync(id);
            if (celulare != null)
            {
                _context.Celulares.Remove(celulare);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelulareExists(int id)
        {
            return _context.Celulares.Any(e => e.Id == id);
        }
    }
}
