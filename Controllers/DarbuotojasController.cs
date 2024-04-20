using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Krepsinio_varzybos.Controllers;

public class DarbuotojasController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        var darbuotojai = DarbuotojasRepo.List();
        return View(darbuotojai);
    }
}
