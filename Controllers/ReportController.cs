namespace Krepsinio_varzybos.Controllers;

using Krepsinio_varzybos.Models.Report;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;

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
        report.Rikiavimas = rep.Rikiavimas;
        _logger.LogInformation(rep.PradziosData + "| |" + (report.Pavarde == null ? "nulis" : report.Pavarde) + "| |" + rep.PabaigosData);

        report.KarjerosEtapai = ReportRepo.GetKarjerosEtapai(report.PradziosData, report.PabaigosData, report.KEKomanda, report.Vardas,
            report.Pavarde, report.KEKiekis, report.Rikiavimas);
        int keCount = 0;
        int zaidejaiCount = 0;
        for(int i = 0; i < report.KarjerosEtapai.Count; i++)
        {
            var ke = report.KarjerosEtapai[i];
            if (ke.Vardas != null)
                keCount++;
            if (i != 0 && report.KarjerosEtapai[i - 1].Id != ke.Id)
                zaidejaiCount++;
        }

        report.VisoKarjerosEtapai = keCount;
        report.VisoZaidejai = zaidejaiCount;

        return View(report);
    }
}

