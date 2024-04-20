namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

public class Darbuotojas
{
    [DisplayName("ID")]
    public int Id { get; set; }

    [DisplayName("Vardas")]
    [MaxLength(20)]
    [Required]
    public string Vardas { get; set; }

    [DisplayName("Pavarde")]
    [MaxLength(20)]
    [Required]
    public string Pavarde { get; set; }

    [DisplayName("Pareigos")]
    [MaxLength(20)]
    [Required]
    public string Pareigos { get; set; }

    [DisplayName("Patirtis")]
    public int Patirtis { get; set; }

    [DisplayName("Sekretoriatas")]
    public string Sekretoriatas { get; set; }
}
