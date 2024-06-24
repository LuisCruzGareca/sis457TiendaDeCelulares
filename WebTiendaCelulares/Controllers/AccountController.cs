using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebTiendaCelulares.ViewModels;
using System.Security.Cryptography;
using System.Text;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class AccountController : Controller
    {
        private readonly LabTiendaCelularesContext _context;

        public AccountController(LabTiendaCelularesContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            // se busca usando el context al usuario que el campo email sea igual al email que ha introducido el usuario en el formulario y que su 
            //contraseña sea igual a la contraseña codificada en md5 que ha introducido el usuario en el formulario
            var usuario = _context.Usuarios.Where(x => x.Email == model.usuario &&
                    x.Password == GetMD5Hash(model.clave)).FirstOrDefault();
            if (usuario != null)
            {
                TempData["isLogged"] = true;
                //se guardad el email del usuario que he buscado en la base de datos en un Claim para luego poder recuperarlo y a la hora de 
                //comprar poder buscar al usuario usando su email
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, usuario.Email),
                    new Claim(ClaimTypes.Role, "admin", ClaimValueTypes.String)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(15),
                    IsPersistent = model.recordarme
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                if (returnUrl == null) returnUrl = ViewData["ReturnUrl"]?.ToString();
                if (returnUrl != null) return Redirect(returnUrl);
                else return RedirectToAction(nameof(HomeController.Index), "Home");//si todo es correcto se redirige al usuario a la paginad e inicio
            }
            else
            {
                //si algo es incorrecto se redirige al usuario a la pagina de login con el mensaje de error.
                ViewBag.ReturnUrl = returnUrl;
                ModelState.AddModelError("", "Email o contraseña inválidos.");
                return View(model);
            }
        }
        public async Task<IActionResult> Logout()
        {
            TempData["isLogged"] = false;
            //se deslogea al usuario
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(HomeController.Index), "Home");
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
