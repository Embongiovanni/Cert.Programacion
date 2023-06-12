﻿using ASP_.NET_MVC.Data;
using ASP_.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace ASP_.NET_MVC.Controllers
{
    public class InstitucionController : Controller
    {
        private readonly InstitutoDbContext _context;

        public InstitucionController(InstitutoDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar la descripción de la institución y los cursos ofrecidos
        public ActionResult Index()
        {
            var institucion = _context.Instituciones.FirstOrDefault();
            if (institucion == null)
            {
                return RedirectToAction("Error404", "Error");
            }

            return View(institucion);
        }

        // Acción para actualizar los cursos ofrecidos
        [HttpGet]
        public ActionResult ActualizarCursos(int id)
        {
            Institucion institucion = _context.Instituciones.Find(id);
            if (institucion == null)
            {
                return RedirectToAction("Error404", "Error");
            }

            return View(institucion);
        }

        [HttpPost]
        public ActionResult ActualizarCursos(Institucion institucion)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(institucion).State = EntityState.Modified;
                _context.SaveChanges();
                TempData["Mensaje"] = "Curso actualizado exitosamente";
                return RedirectToAction("Index"); // Redirigir a la página principal de la institución
            }

            return View(institucion);
        }
    }
}
