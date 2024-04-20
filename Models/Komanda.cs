namespace Krepsinio_varzybos.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Komanda
{
	[DisplayName("Komandos ID")]
	public int Id { get; set; }

	[DisplayName("Pavadinimas")]
	[MaxLength(20)]
	[Required]
	public string Pavadinimas { get; set; }

	[DisplayName("Salis")]
	[MaxLength(20)]
	[Required]
	public string Salis { get; set; }

	[DisplayName("Miestas")]
	[MaxLength(20)]
	[Required]
	public string Miestas { get; set; }

	[DisplayName("Ikurimo Data")]
	[DataType(DataType.Date)]
	public DateTime IkurimoData { get; set; }
}
