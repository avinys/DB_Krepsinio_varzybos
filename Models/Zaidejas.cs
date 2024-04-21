namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Utilities;

public class Zaidejas
{
	[DisplayName("ID")]
	public int Id { get; set; }

	[DisplayName("Vardas")]
	[MaxLength(20)]
	public string Vardas { get; set; }

	[DisplayName("Pavarde")]
	[MaxLength(20)]
	public string Pavarde { get; set; }

	[DisplayName("Ugis")]
	public int Ugis { get; set; }

	[DisplayName("Svoris")]
	public int Svoris { get; set; }

	[DisplayName("Amzius")]
	public int Amzius { get; set; }

	[DisplayName("Gimimo Vieta")]
	[MaxLength(20)]
	public string GimimoVieta { get; set; }

	[DisplayName("Tautybe")]
	[MaxLength(20)]
	public string Tautybe { get; set; }

	[DisplayName("Pozicija")]
	[MaxLength(2)]
	public string Pozicija { get; set; }

	[DisplayName("Komanda")]
    [MaxLength(20)]
    public string KomandaPavadinimas { get; set; }
}

public class ZaidejasCE
{
    public class ZaidejasM
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

        [DisplayName("Ugis")]
        [Required]
        public int Ugis { get; set; }

        [DisplayName("Svoris")]
        [Required]
        public int Svoris { get; set; }

        [DisplayName("Amzius")]
        [Required]
        public int Amzius { get; set; }

        [DisplayName("Gimimo Vieta")]
        [MaxLength(20)]
        public string GimimoVieta { get; set; }

        [DisplayName("Tautybe")]
        [MaxLength(20)]
        [Required]
        public string Tautybe { get; set; }

        [DisplayName("Pozicija")]
        [MaxLength(2)]
        public string Pozicija { get; set; }

        [DisplayName("Komanda")]
        [Required]
        public int FkKomanda { get; set; }

        public override string ToString()
        {
            return $"ZaidejasM {{ ID: {Id}, Vardas: \"{Vardas}\", Pavarde: \"{Pavarde}\", Ugis: {Ugis} cm, " +
                   $"Svoris: {Svoris} kg, Amzius: {Amzius}, Gimimo Vieta: \"{GimimoVieta}\", Tautybe: \"{Tautybe}\", " +
                   $"Pozicija: \"{Pozicija}\", Komanda ID: {FkKomanda} }}";
        }
    }

    public class ZaidejoKarjerosEtapasM
    {
        public int InListId { get; set; }
        [DisplayName("Pradzios data")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime PradziosData { get; set; }
        [DisplayName("Pabaigos data")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime PabaigosData { get; set; }
        [DisplayName("Komanda")]
        [Required]
        public string Komanda { get; set; }
        [DisplayName("Pareigos")]
        [Required]
        public int FkPareigos { get; set; }
    }

    public class ListsM
    {
        public IList<SelectListItem> Komandos { get; set; }
        public IList<SelectListItem> KarjerosEtapai { get; set; }
        public IList<SelectListItem> Pareigos { get; set; }
    }

    public ZaidejasM Zaidejas { get; set; } = new ZaidejasM();
    public ListsM Lists { get; set; } = new ListsM() { 
        Komandos = new List<SelectListItem>(),
        KarjerosEtapai = new List<SelectListItem>(),
        Pareigos = new List<SelectListItem>()
    };
    public IList<ZaidejoKarjerosEtapasM> ZaidejoKarjerosEtapai { get; set; } = new List<ZaidejoKarjerosEtapasM>();
}