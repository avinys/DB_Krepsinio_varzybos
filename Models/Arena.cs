namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

public class Arena
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Pavadinimas")]
    [MaxLength(20)]
    [Required]
    public string Pavadinimas { get; set; }

    [DisplayName("Miestas")]
    [MaxLength(20)]
    [Required]
    public string Miestas { get; set; }

    [DisplayName("Talpa")]
    [Required]
    public string Talpa { get; set; }

    [DisplayName("Savininkas")]
    [MaxLength(40)]
    [Required]
    public string Savininkas { get; set; }

    [DisplayName("Atidarymo data")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Atidarymas { get; set; }
}
