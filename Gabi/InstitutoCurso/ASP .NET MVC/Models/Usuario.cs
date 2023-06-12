using System.ComponentModel.DataAnnotations;

namespace ASP_.NET_MVC.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
