using System.ComponentModel.DataAnnotations;

namespace JeanMorales_Clase2_ProyectoMVC.Models
{
    public class Carrera
    {
        [Required]
        [Range(1,1000)]
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
