using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTiendaCelulares.Models;
using WebTiendaCelulares.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebTiendaCelulares.Controllers
{
    public class ComprasController : Controller
    {
        private readonly LabTiendaCelularesContext _context;

        public ComprasController(LabTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            var labTiendaCelularesContext = await _context.Compras.
                Include(c => c.IdCelularNavigation).
                Include(c => c.IdUsuarioNavigation).
                Select(c => new CompraViewModel
                { 
                    Id = c.Id,
                    Total = c.Total,
                    FechaVenta = c.FechaVenta,
                    Usuario = c.IdUsuarioNavigation.Nombre,
                    Celular = c.IdCelularNavigation.Nombre
                }).ToListAsync();
            ;

            return View(labTiendaCelularesContext);
        }

        // GET: Compras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.IdCelularNavigation)
                .Include(c => c.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compras/Create
        public async Task<IActionResult> Create(int celularId)
        {
            var celular = _context.Celulares.Find(celularId);
            var compra = new CrearCompraViewModel();

            compra.Total = celular.Precio;
            compra.Celular = celular.Nombre;
            compra.CelularId = celularId;
                

            return View(compra);
        }

        // POST: Compras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Total,Celular,CelularId")] CrearCompraViewModel compraVm)
        {
            if (ModelState.IsValid)
            {
                

                var userEmail = User.FindFirstValue(ClaimTypes.Email);

                
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == userEmail);
                if (usuario != null)
                {
                
                    Compra compra = new Compra();
                    compra.Total = compraVm.Total;
                    compra.IdCelular = compraVm.CelularId;
                    compra.IdUsuario = usuario.Id;

                    _context.Add(compra);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }else {
                    return RedirectToAction("Login", "Account");
                }
               
            }

            
            return RedirectToAction("Create", "Compra", new { celularId = compraVm.CelularId });
        }


        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Celulares, "Id", "Nombre", compra.IdCelular);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre", compra.IdUsuario);
            return View(compra);
        }

        // POST: Compras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DireccionEnvio,Total,FechaVenta,IdUsuario,IdCelular")] Compra compra)
        {
            if (id != compra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraExists(compra.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Celulares, "Id", "Nombre", compra.IdCelular);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre", compra.IdUsuario);
            return View(compra);
        }

        // GET: Compras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.IdCelularNavigation)
                .Include(c => c.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compra = await _context.Compras.FindAsync(id);
            if (compra != null)
            {
                _context.Compras.Remove(compra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(int id)
        {
            return _context.Compras.Any(e => e.Id == id);
        }
    }
}
