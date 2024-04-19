namespace Krepsinio_varzybos.Controllers;

using Microsoft.AspNetCore.Mvc;

using Krepsinio_varzybos.Repositories;
using Krepsinio_varzybos.Models;

public class ArenaController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        var arenos = ArenaRepo.List();
        return View(arenos);
    }

}
