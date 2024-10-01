using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JeanMorales_Clase2_ProyectoMVC.Models
{
    [Authorize] //Dar seguridad, afecta a todos los hijos de la clase
    public class EstudianteUDLA
    {
        [Required]
        public string IDBanner { get; set; }
        [AllowNull]   //Aceptar nulos en correo
        [EmailAddress] //Validar correo
        public string Correo { get; set; }
        [MaxLength(100)] //maximo 100 caracteres en nombre
        
        public string Nombre { get; set; }
        public Carrera carrera { get; set; }
    }
}
