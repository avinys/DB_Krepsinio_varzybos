using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Krepsinio_varzybos.Models.Report;

//Zaidejas
public class KarjerosEtapas
{
    [DisplayName("ID")]
    public int Id { get; set; }
    [DisplayName("Vardas")]
    public string Vardas { get; set; }
    [DisplayName("Pavardė")]
    public string Pavarde { get; set; }
    [DisplayName("Dabartinė komanda")]
    public string KomandaDabar { get; set; }
    [DisplayName("Pareigos")]
    public string Pareigos { get; set; }
    public int KEKiekis { get; set; }
    [DisplayName("Komanda")]
    public string Komanda { get; set; }
    public int KarjerosEtapasId { get; set; }
    [DisplayName("Pradžios data")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime PradziosData { get; set; }
    [DisplayName("Pabaigos data")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime PabaigosData { get; set; }
    [DisplayName("Karjeros etapo trukmė")]
    public int Trukme { get; set; }
    public int KarjerosEtapasSkaicius { get; set; }
    public int VisoDienu { get; set; }
    public int VisoEtapu { get; set; }
    public int MaxTrukme { get; set; }
    public int VidTrukme { get; set; }
    //public int KomandaIlgiausia { get; set; }
}
public class Report
{
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? PradziosData { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? PabaigosData { get; set; }
    public int? KEKomanda { get; set; }
    public string? KEKomandaPav { get; set; }
    public string? Vardas { get; set; }
    public string? Pavarde { get; set; }
    public int? KEKiekis { get; set; }
    public int? Rikiavimas { get; set; }
    public string? RikiavimasPav { get; set; }
    public int VisoZaidejai { get; set; }
    public int VisoKarjerosEtapai { get; set; }
    public int VisoMaxTrukme { get; set; }
    public int VisoVidTrukme { get; set; }
    public List<KarjerosEtapas> KarjerosEtapai { get; set; }
    public Lists DropDowns { get; set; } = new Lists()
    {
        Komandos = new List<SelectListItem>(),
        Rikiavimas = new List<SelectListItem>(){
        new SelectListItem { Text = "Vardas didėjančiai", Value = "1" },
        new SelectListItem { Text = "Vardas mažėjančiai", Value = "2" },
        new SelectListItem { Text = "Pavarde didėjančiai", Value = "3" },
        new SelectListItem { Text = "Pavarde mažėjančiai", Value = "4" }
    }
    };
}

public class Lists
{
    public IList<SelectListItem> Komandos { get; set; }
    public IList<SelectListItem> Rikiavimas { get; set; }
}
