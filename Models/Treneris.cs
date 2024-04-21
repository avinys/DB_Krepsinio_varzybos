namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
public class TrenerisL
{
	[DisplayName("Id")]
	public int Id { get; set; }

	[DisplayName("Vardas")]
	[MaxLength(20)]
	[Required]
	public string Vardas { get; set; }

	[DisplayName("Pavarde")]
	[MaxLength(20)]
	[Required]
	public string Pavarde { get; set; }

	[DisplayName("Amzius")]
	public int Amzius { get; set; }

	[DisplayName("Tautybe")]
	[MaxLength(20)]
	[Required]
	public string Tautybe { get; set; }

	[DisplayName("Patirtis")]
	public int Patirtis { get; set; }

	[DisplayName("Pareigos")]
	[MaxLength(40)]
	[Required]
	public string Pareigos { get; set; }

	[DisplayName("Komanda")]
	[MaxLength(20)]
	[Required]
	public string Komanda { get; set; }
}

public class TrenerisCE
{
	public class TrenerisM
	{
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Vardas")]
        [MaxLength(20)]
        [Required]
        public string Vardas { get; set; }

        [DisplayName("Pavarde")]
        [MaxLength(20)]
        [Required]
        public string Pavarde { get; set; }

        [DisplayName("Amzius")]
        public int Amzius { get; set; }

        [DisplayName("Tautybe")]
        [MaxLength(20)]
        [Required]
        public string Tautybe { get; set; }

        [DisplayName("Patirtis")]
        public int Patirtis { get; set; }

        [DisplayName("Pareigos")]
        [MaxLength(40)]
        [Required]
        public string Pareigos { get; set; }

        [DisplayName("Komanda")]
        [Required]
        public int FkKomanda { get; set; }
    }

	public class ListsM
	{
		public IList<SelectListItem> Komandos { get; set; }
	}
	public TrenerisM Treneris { get; set; } = new TrenerisM();
	public ListsM Lists { get; set; } = new ListsM() { Komandos = new List<SelectListItem>() };
}
