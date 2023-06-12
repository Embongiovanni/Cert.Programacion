﻿using ASP_.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;



namespace ASP_.NET_MVC.Controllers
{
    public class UsuariosController : Controller
    {
        private InstitutoDbContext _context;

        public UsuariosController()
        {
            _context = new InstitutoDbContext();
        }

        // Acción para registrar un nuevo usuario
        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Guardar el nuevo usuario en la base de datos
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                // Redirigir a la página de inicio de sesión o a otra vista según tus necesidades
                return RedirectToAction("Login");
            }

            return View(usuario);
        }

        // Acción para editar el perfil de usuario

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return RedirectToAction("Error404", "Error");
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", "Home"); // Redirigir a la página principal
            }

            return View(usuario);
        }

        // Otras acciones del controlador para baja de usuario, etc.
    }
}
