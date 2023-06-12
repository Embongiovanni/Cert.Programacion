using ASP_.NET_MVC.Data;
using ASP_.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;


namespace ASP_.NET_MVC.Controllers
{
    public class CursosController : Controller
    {
        private readonly InstitutoDbContext _context;

        public CursosController(InstitutoDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar los cursos disponibles
        public ActionResult Index()
        {
            var cursos = _context.Cursos.Where(c => c.Disponible).ToList();
            return View(cursos);
        }

        // Acción para ver detalles de un curso específico
        public ActionResult Detalles(int id)
        {
            Curso curso = _context.Cursos.Find(id);
            if (curso == null)
            {
                return RedirectToAction("Error404", "Error");
            }

            return View(curso);
        }
    }
}
