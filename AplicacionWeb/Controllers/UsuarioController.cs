using AplicacionWeb.Models;
using CasosDeUsoCompartida.DTOs.Usuarios;
using CasosDeUsoCompartida.Interfaces.Usuario;
using logicaDeNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class UsuarioController : Controller
    {
        IAdd<UsuarioDTO> _add;

        public UsuarioController(IAdd<UsuarioDTO> add)
        {
            _add = add;
        }

       public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMUsuario usuario)
        {
            try
            {
                UsuarioDTO nuevoUsuario = new UsuarioDTO
                {
                    Id = usuario.Id,
                    Email = usuario.Email,
                    Contrasena = usuario.Contrasena
                };

                _add.Execute(nuevoUsuario); // ✔ Ahora es el tipo correcto
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ModelState.AddModelError("", "Hubo un error al crear el usuario.");
                return View(usuario);
            }
        }


    }
}
