using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Krepsinio_varzybos.Controllers;

public class KomandaController : Controller
{
	[HttpGet]
	public ActionResult Index()
	{
		var komandos = KomandaRepo.List();
		return View(komandos);
	}

    [HttpGet]
    public ActionResult Create()
    {
        var komanda = new Komanda();
        return View(komanda);
    }

    [HttpPost]
    public ActionResult Create(Komanda komanda)
    {
        //form field validation passed?
        if (ModelState.IsValid)
        {
            KomandaRepo.Insert(komanda);

            //save success, go back to the entity list
            return RedirectToAction("Index");
        }
        //ViewBag.Alert = "alert('This is an alert message from the server side.');";
        Console.WriteLine("Iskviete");
        //form field validation failed, go back to the form
        return View(komanda);
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var komanda = KomandaRepo.Find(id);
        return View(komanda);
    }

    [HttpPost]
    public ActionResult Edit(int id, Komanda komanda)
    {
        //form field validation passed?
        if (ModelState.IsValid)
        {
            KomandaRepo.Update(komanda);

            //save success, go back to the entity list
            return RedirectToAction("Index");
        }

        //form field validation failed, go back to the form
        return View(komanda);
    }

    [HttpGet]
    public ActionResult Delete(int id)
    {
        var komanda = KomandaRepo.Find(id);
        return View(komanda);
    }

    [HttpPost]
    public ActionResult DeleteConfirm(int id)
    {
        //try deleting, this will fail if foreign key constraint fails
        try
        {
            KomandaRepo.Delete(id);

            //deletion success, redired to list form
            return RedirectToAction("Index");
        }
        //entity in use, deletion not permitted
        catch (MySql.Data.MySqlClient.MySqlException)
        {
            //enable explanatory message and show delete form
            ViewData["deletionNotPermitted"] = true;

            var komanda = KomandaRepo.Find(id);
            return View("Delete", komanda);
        }
    }
}
