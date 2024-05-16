namespace Krepsinio_varzybos.Controllers;

using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Models.Report;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;
using static Krepsinio_varzybos.Models.ZaidejasCE;
using System.Diagnostics;
using Krepsinio_varzybos.Views.Zaidejas;

public class ReportController : Controller
{
    private readonly ILogger<ReportController> _logger;

    public ReportController(ILogger<ReportController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public ActionResult KarjerosEtapai(Report rep/*DateTime? dateFrom, DateTime? dateTo, string? KEKomanda, string? vardas, string? pavarde, int? kiekis, int? rikiavimas*/)
    {
        var report = new Report();
        //report.PradziosData = dateFrom;
        //report.PabaigosData = dateTo?.AddHours(23).AddMinutes(59).AddSeconds(59);
        //report.KEKomanda = KEKomanda;
        //report.Vardas = vardas;
        //report.Pavarde = pavarde;
        //report.KEKiekis = kiekis;
        //report.Rikiavimas = rikiavimas;

        report.PradziosData = rep.PradziosData;
        report.PabaigosData = rep.PabaigosData?.AddHours(23).AddMinutes(59).AddSeconds(59); ;
        report.KEKomanda = rep.KEKomanda;
        report.Vardas = rep.Vardas;
        report.Pavarde = rep.Pavarde;
        report.KEKiekis = rep.KEKiekis;
        if (rep.KEKomanda == null)
            report.KEKomandaPav = null;
        else
            report.KEKomandaPav = KomandaRepo.Find((int)rep.KEKomanda).Pavadinimas;

        switch(rep.Rikiavimas)
        {
            case 1:
                report.RikiavimasPav = "vardas didėjančiai";
                break;
            case 2:
                report.RikiavimasPav = "vardas mažėjančiai";
                break;
            case 3:
                report.RikiavimasPav = "pavardė didėjančiai";
                break;
            case 4:
                report.RikiavimasPav = "pavardė mažėjančiai";
                break;
            default:
                report.RikiavimasPav = null;
                break;
        }

        report.Rikiavimas = rep.Rikiavimas;
        _logger.LogInformation(rep.PradziosData + "| |" + (report.Pavarde == null ? "nulis" : report.Pavarde) + "| |" + rep.PabaigosData);

        report.KarjerosEtapai = ReportRepo.GetKarjerosEtapai(report.PradziosData, report.PabaigosData, report.KEKomanda, report.Vardas,
            report.Pavarde, report.KEKiekis, report.Rikiavimas);
        int keCount = 0;
        int zaidejaiCount = 0;
        int maxTrukme = 0;
        double vidurkis = 0;
        for(int i = 0; i < report.KarjerosEtapai.Count; i++)
        {
            var ke = report.KarjerosEtapai[i];
            if (ke.Vardas != null)
            {
                keCount++;
                maxTrukme = Math.Max(maxTrukme, report.KarjerosEtapai[i].Trukme);
                vidurkis += report.KarjerosEtapai[i].VidTrukme;
            }
            if (i != 0 && report.KarjerosEtapai[i - 1].Id != ke.Id)
                zaidejaiCount++;
        }

        report.VisoKarjerosEtapai = keCount;
        report.VisoZaidejai = zaidejaiCount + 1;
        report.VisoMaxTrukme = maxTrukme;
        report.VisoVidTrukme = (int)(vidurkis / keCount);

        PopulateLists(report);

        return View(report);
    }
    public static void PopulateLists(Report report)
    {
        var komandos = KomandaRepo.List();

        report.DropDowns.Komandos =
            komandos.Select(it =>
            {
                return
                        new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                        {
                            Value = Convert.ToString(it.Id),
                            Text = it.Pavadinimas
                        };
            }).ToList();
    }
}

