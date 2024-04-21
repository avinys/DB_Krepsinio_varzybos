using System.Runtime.Intrinsics.X86;
using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Krepsinio_varzybos.Models.ZaidejasCE;

namespace Krepsinio_varzybos.Controllers;

public class ZaidejasController : Controller
{
	[HttpGet]
	public ActionResult Index()
	{
		var zaidejai = ZaidejasRepo.ListZaidejas();
		return View(zaidejai);
	}

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var zaidejasCE = ZaidejasRepo.FindZaidejasCE(id);
        zaidejasCE.ZaidejoKarjerosEtapai = ZaidejasRepo.ListZaidejoKarjerosEtapai(id);
        PopulateSelections(zaidejasCE);

        return View(zaidejasCE);
    }

    private readonly ILogger<ZaidejasController> _logger;

    public ZaidejasController(ILogger<ZaidejasController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult Edit(int id, int? save, int? add, int? remove, ZaidejasCE zaidejasCE)
    {
        if(add != null)
        {
            var karjerosEtapasNaujas = new ZaidejasCE.ZaidejoKarjerosEtapasM
            {
                InListId = zaidejasCE.ZaidejoKarjerosEtapai.Count > 0 ?
                    zaidejasCE.ZaidejoKarjerosEtapai.Max(it => it.InListId) + 1 :
                    0,

                PradziosData = DateTime.Now,
                PabaigosData= DateTime.Now,
                Komanda="",
                FkPareigos=0
            };
            zaidejasCE.ZaidejoKarjerosEtapai.Add(karjerosEtapasNaujas);
            ModelState.Clear();
            PopulateSelections(zaidejasCE);
            return View(zaidejasCE);

        }
        if (remove != null)
        {
            //Remove the career time from screen, but not from base
            zaidejasCE.ZaidejoKarjerosEtapai = zaidejasCE.ZaidejoKarjerosEtapai.Where(it => it.InListId != remove.Value).ToList();
            ModelState.Clear();
            PopulateSelections(zaidejasCE);
            return View(zaidejasCE);
        }
        if (save != null)
        {
            _logger.LogInformation($"Received data for Zaidejas: {zaidejasCE.Zaidejas.ToString()}");
            if (ModelState.IsValid)
            {
                ZaidejasRepo.UpdateZaidejas(zaidejasCE);
                ZaidejasRepo.DeleteZaidejoKarjerosEtapai(zaidejasCE.Zaidejas.Id);
                foreach (var karjerosEtapas in zaidejasCE.ZaidejoKarjerosEtapai)
                {
                    ZaidejasRepo.InsertZaidejoKarjerosEtapas(zaidejasCE.Zaidejas.Id, karjerosEtapas);
                }
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                foreach (var entry in ModelState)
                {
                    if (entry.Value.Errors.Count > 0)
                    {
                        foreach (var error in entry.Value.Errors)
                        {
                            _logger.LogError($"Error in {entry.Key}: {error.ErrorMessage}");
                        }
                    }
                }
            }
            throw new Exception("Should not reach here.");
        }
        return View(zaidejasCE);
    }

    //[HttpPost]
    //public ActionResult Edit(int id, int? save, int? add, int? remove, ZaidejasCE zaidejasCE)
    //{
    //    _logger.LogInformation($"Received data for Zaidejas: {zaidejasCE.Zaidejas.ToString()}");

    //    if (!ModelState.IsValid)
    //    {
    //        foreach (var entry in ModelState)
    //        {
    //            if (entry.Value.Errors.Count > 0)
    //            {
    //                foreach (var error in entry.Value.Errors)
    //                {
    //                    _logger.LogError($"Error in {entry.Key}: {error.ErrorMessage}");
    //                }
    //            }
    //        }
    //        _logger.LogError("ModelState is invalid. Returning to view with errors.");
    //        PopulateSelections(zaidejasCE);
    //        return View(zaidejasCE);
    //    }

    //    _logger.LogInformation("ModelState is valid. Proceeding with database update.");
    //    ZaidejasRepo.UpdateZaidejas(zaidejasCE);
    //    //Thread.Sleep(10000);
    //    return RedirectToAction("Index");
    //}

    [HttpGet]
    public ActionResult Create()
    {
        var autoCE = new ZaidejasCE();
        PopulateSelections(autoCE);

        return View(autoCE);
    }

    [HttpPost]
    public ActionResult Create(int id, int? save, int? add, int? remove, ZaidejasCE zaidejasCE)
    {
        if (add != null)
        {
            var karjerosEtapasNaujas = new ZaidejasCE.ZaidejoKarjerosEtapasM
            {
                InListId = zaidejasCE.ZaidejoKarjerosEtapai.Count > 0 ?
                    zaidejasCE.ZaidejoKarjerosEtapai.Max(it => it.InListId) + 1 :
                    0,

                PradziosData = DateTime.Now,
                PabaigosData = DateTime.Now,
                Komanda = "",
                FkPareigos = 0
            };
            zaidejasCE.ZaidejoKarjerosEtapai.Add(karjerosEtapasNaujas);
            ModelState.Clear();
            PopulateSelections(zaidejasCE);
            return View(zaidejasCE);

        }
        if (remove != null)
        {
            //Remove the career time from screen, but not from base
            zaidejasCE.ZaidejoKarjerosEtapai = zaidejasCE.ZaidejoKarjerosEtapai.Where(it => it.InListId != remove.Value).ToList();
            ModelState.Clear();
            PopulateSelections(zaidejasCE);
            return View(zaidejasCE);
        }
        if (save != null)
        {
            if (ModelState.IsValid)
            {
                zaidejasCE.Zaidejas.Id = ZaidejasRepo.InsertZaidejas(zaidejasCE);
                foreach (var karjerosEtapas in zaidejasCE.ZaidejoKarjerosEtapai)
                {
                    ZaidejasRepo.InsertZaidejoKarjerosEtapas(zaidejasCE.Zaidejas.Id, karjerosEtapas);
                }
                return RedirectToAction("Index");
            }
            else
            {
                PopulateSelections(zaidejasCE);
                return View(zaidejasCE);
            }
        }
        throw new Exception("Should not reach here.");
    }

    [HttpGet]
    public ActionResult Delete(int id)
    {
        _logger.LogInformation("Get: " + id);
        var zaidejasCE = ZaidejasRepo.FindZaidejasCE(id);
        //PopulateSelections(zaidejasCE);
        return View(zaidejasCE);
    }

    [HttpPost]
    public ActionResult DeleteConfirm(int id)
    {
        var zaidejasCE = ZaidejasRepo.FindZaidejasCE(id);
        if (zaidejasCE != null)
        {
            ZaidejasRepo.DeleteZaidejoKarjerosEtapai(id);
            ZaidejasRepo.DeleteZaidejas(id);
            return RedirectToAction("Index");
        }
        else
        {
            ViewData["deletionNotPermitted"] = true;
            return View("Delete", zaidejasCE);
        }

        //_logger.LogInformation("Post: " + id);
        //_logger.LogInformation($"Received id");
        //try
        //{
        //    _logger.LogInformation($"Database try to delete");
        //    ZaidejasRepo.DeleteZaidejas(id);
        //    _logger.LogInformation($"Database delete complete");
        //    return RedirectToAction("Index");
        //}
        //catch (MySql.Data.MySqlClient.MySqlException e)
        //{
        //    _logger.LogInformation($"Deleting failed");
        //    _logger.LogInformation($"Deleting failed: " + e.ToString());
        //    ViewData["deletionNotPermitted"] = true;

        //    var zaidejasCE = ZaidejasRepo.FindZaidejasCE(id);
        //    PopulateSelections(zaidejasCE);

        //    return View("Delete", zaidejasCE);
        //}
    }

    public void PopulateSelections(ZaidejasCE zaidejasCE)
    {
        {
            zaidejasCE.Lists.Komandos = new List<SelectListItem>();
            var komandos = KomandaRepo.List();
            var pareigos = PareigosRepo.List();

            foreach (var komanda in komandos)
            {
                var sle =
                        new SelectListItem
                        {
                            Value = Convert.ToString(komanda.Id),
                            Text = komanda.Pavadinimas
                        };
                zaidejasCE.Lists.Komandos.Add(sle);
            }
            foreach (var pareiga in pareigos)
            {
                var sle =
                        new SelectListItem
                        {
                            Value = Convert.ToString(pareiga.Id),
                            Text = pareiga.Pavadinimas
                        };
                zaidejasCE.Lists.Pareigos.Add(sle);
            }
            zaidejasCE.Lists.KarjerosEtapai = new List<SelectListItem>();
        }
    }
}
