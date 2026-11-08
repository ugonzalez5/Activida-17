using System.ComponentModel.DataAnnotations;

namespace Actividad17_EFCore.Models;

public class Estudiante
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(120, ErrorMessage = "El nombre no puede superar 120 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Escribe un correo válido.")]
    [StringLength(160)]
    public string Correo { get; set; } = string.Empty;

    [Range(typeof(decimal), "0", "10", ErrorMessage = "La calificación debe estar entre 0 y 10.")]
    public decimal Calificacion { get; set; }
}
