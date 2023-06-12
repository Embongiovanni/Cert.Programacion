using System.ComponentModel.DataAnnotations;

namespace ASP_.NET_MVC.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Disponible { get; set; }
    }
}
