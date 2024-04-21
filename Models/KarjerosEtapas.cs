namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Krepsinio_varzybos.Models.ZaidejasCE;

public class KarjerosEtapasL
{
    [DisplayName("Id")]
    public int Id { get; set; }

    [DisplayName("Pradzios_data")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Pradzios_data  { get; set; }

    [DisplayName("Pabaigos_data")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Pabaigos_data { get; set; }

    [DisplayName("Komanda")]
    [MaxLength(40)]
    [Required]
    public string Komanda { get; set; }

    [DisplayName("Zaidejo Vardas")]
    [MaxLength(20)]
    public string ZaidejasVardas { get; set; }

    [DisplayName("Zaidejo Pavarde")]
    [MaxLength(20)]
    public string ZaidejasPavarde { get; set; }

    [DisplayName("Pareigos")]
    [MaxLength(40)]
    public string PareigosPavadinimas { get; set; }
}

public class KarjerosEtapasCE
{
    public class KarjerosEtapasM
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Pradzios_data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Pradzios_data { get; set; }

        [DisplayName("Pabaigos_data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Pabaigos_data { get; set; }

        [DisplayName("Komanda")]
        [MaxLength(40)]
        [Required]
        public string Komanda { get; set; }

        [DisplayName("Zaidejas")]
        [Required]
        public int FkZaidejas { get; set; }

        [DisplayName("Pareigos")]
        [Required]
        public int FkPareigos { get; set; }
    }
    public class ListsM
    {
        public IList<SelectListItem> Zaidejai { get; set; }
        public IList<SelectListItem> Pareigos { get; set; }
    }

    public KarjerosEtapasM KarjerosEtapas { get; set; } = new KarjerosEtapasM();
    public ListsM Lists { get; set; } = new ListsM()
    {
        Zaidejai = new List<SelectListItem>(),
        Pareigos = new List<SelectListItem>()
    };



}

