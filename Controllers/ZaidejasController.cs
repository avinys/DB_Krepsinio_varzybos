using System.Runtime.Intrinsics.X86;
using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Krepsinio_varzybos.Controllers;

public class ZaidejasController : Controller
{
	[HttpGet]
	public ActionResult Index()
	{
		var zaidejai = ZaidejasRepo.List();
		return View(zaidejai);
	}

    [HttpGet]
    public ActionResult Create()
    {
        var autoCE = new ZaidejasCE();
        PopulateSelections(autoCE);

        return View(autoCE);
    }

    [HttpPost]
    public ActionResult Create(ZaidejasCE zaidejasCE)
    {
        //form field validation passed?
        if (ModelState.IsValid)
        {
            ZaidejasRepo.InsertZaidejas(zaidejasCE);

            //save success, go back to the entity list
            return RedirectToAction("Index");
        }

        //form field validation failed, go back to the form
        PopulateSelections(zaidejasCE);
        return View(zaidejasCE);
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var zaidejasCE = ZaidejasRepo.FindZaidejasCE(id);
        PopulateSelections(zaidejasCE);

        return View(zaidejasCE);
    }

    private readonly ILogger<ZaidejasController> _logger;

    public ZaidejasController(ILogger<ZaidejasController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult Edit(int id, ZaidejasCE zaidejasCE)
    {
        _logger.LogInformation($"Received data for Zaidejas: {zaidejasCE.Zaidejas.ToString()}");

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
            _logger.LogError("ModelState is invalid. Returning to view with errors.");
            PopulateSelections(zaidejasCE);
            return View(zaidejasCE);
        }

        _logger.LogInformation("ModelState is valid. Proceeding with database update.");
        ZaidejasRepo.UpdateZaidejas(zaidejasCE);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Delete(int id)
    {
        var autoEvm = ZaidejasRepo.FindZaidejasCE(id);
        return View(autoEvm);
    }

    [HttpPost]
    public ActionResult DeleteConfirm(int id)
    {
        //try deleting, this will fail if foreign key constraint fails
        try
        {
            ZaidejasRepo.DeleteZaidejas(id);

            //deletion success, redired to list form
            return RedirectToAction("Index");
        }
        //entity in use, deletion not permitted
        catch (MySql.Data.MySqlClient.MySqlException)
        {
            //enable explanatory message and show delete form
            ViewData["deletionNotPermitted"] = true;

            var autoCE = ZaidejasRepo.FindZaidejasCE(id);
            PopulateSelections(autoCE);

            return View("Delete", autoCE);
        }
    }

    public void PopulateSelections(ZaidejasCE zaidejasCE)
    {
        {
            zaidejasCE.Lists.Komandos = new List<SelectListItem>();
            var komandos = KomandaRepo.List();

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
        }
    }
}
