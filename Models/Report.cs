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
    public string? KEKomanda { get; set; }
    public string? Vardas { get; set; }
    public string? Pavarde { get; set; }
    public int? KEKiekis { get; set; }
    public int? Rikiavimas { get; set; }
    public int VisoZaidejai { get; set; }
    public int VisoKarjerosEtapai { get; set; }
    public List<KarjerosEtapas> KarjerosEtapai { get; set; }
}

public class AtskirasZaidejas
{
    public int Id { get; set; }
    public string Vardas { get; set; }
    public string Pavarde { get; set; }
    public string DabartineKomanda { get; set; }
    public List<AtskirasKarjerosEtapas> KarjerosEtapai { get; set; }
    public int VisoZaidejai { get; set; }
    public int VisoKarjerosEtapai { get; set; }
}
public class AtskirasKarjerosEtapas
{
    public string Pareigos { get; set; }
    public DateTime PradziosData { get; set; }
    public DateTime PabaigosData { get; set; }
    public int Trukme { get; set; }
}