namespace Krepsinio_varzybos.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
public class Treneris
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
