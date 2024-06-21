using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTiendaCelulares.Models;
using System;
using System.Security.Cryptography;
using System.Text;


namespace WebTiendaCelulares.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly LabTiendaCelularesContext _context;

        public UsuariosController(LabTiendaCelularesContext context)
        {
            _context = context;
        }
        // GET: UsuariosController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToArrayAsync());
        }

        // GET: UsuariosController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: UsuariosController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Password,Nombre")] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                usuario.Password = GetMD5Hash(usuario.Password);
                _context.Add(usuario);
                await _context.SaveChangesAsync();

                if (!User.Identity.IsAuthenticated)
                {
                    return RedirectToAction("Login", "Account");
                }

                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: UsuariosController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.Password = null;
            return View(usuario);
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Password,Nombre")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.Password = GetMD5Hash(usuario.Password);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            return View(usuario);
        }

        // GET: UsuariosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

        private string GetMD5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                
                StringBuilder sBuilder = new StringBuilder();

                
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2")); 
                }
                return sBuilder.ToString();
            }
        }
    }
}
