using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentApi.Models;
public enum IncidentStatus
{
    Pendiente,
    EnProceso, // Remove the space; you can format it when displaying
    Resuelto
}

public class Incident
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id { get; set; }

    [Required]
    public string reporter { get; set; }

    [Required]
    [MinLength(10, ErrorMessage = "Por lo menos 10 caracteres en la descripcion.")]
    public string description { get; set; }


    [Required(ErrorMessage = "Ingresa un status valido")]
    public IncidentStatus status { get; set; }
    public DateTime createdAt { get; set; } = DateTime.UtcNow;
}


public class IncidentStaging
{
    [Required]
    public string reporter { get; set; }
    [Required]
    [MinLength(10, ErrorMessage = "Por lo menos 10 caracteres en la descripcion.")]
    public string description { get; set; }
    [Required(ErrorMessage = "Ingresa un status valido")]
    public IncidentStatus status { get; set; }
}

public class IncidentUpdate
{
    [Required(ErrorMessage = "Ingresa un status valido")]
    public IncidentStatus status { get; set; }
}