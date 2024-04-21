using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Krepsinio_varzybos.Controllers
{
    public class KarjerosEtapasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(KarjerosEtapasRepo.ListKarjerosEtapas());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var karCE = KarjerosEtapasRepo.FindKarjerosEtapasCE(id);
            PopulateLists(karCE);
            return View(karCE);
        }
        [HttpPost]
        public ActionResult Edit(int id, KarjerosEtapasCE karjeraCE)
        {
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
                PopulateLists(karjeraCE);
                return View(karjeraCE);
            }

            KarjerosEtapasRepo.UpdateKarjerosEtapas(karjeraCE);
            //Thread.Sleep(10000);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var zaidejasCE = KarjerosEtapasRepo.FindKarjerosEtapasCE(id);
            return View(zaidejasCE);
        }
        private readonly ILogger<KarjerosEtapasController> _logger;
        public KarjerosEtapasController(ILogger<KarjerosEtapasController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            _logger.LogInformation("Post: " + id);
            _logger.LogInformation($"Received id");
            try
            {
                _logger.LogInformation($"Database try to delete");
                KarjerosEtapasRepo.Delete(id);
                _logger.LogInformation($"Database delete complete");
                return RedirectToAction("Index");
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                _logger.LogInformation($"Deleting failed");
                _logger.LogInformation($"Deleting failed: " + e.ToString());
                ViewData["deletionNotPermitted"] = true;

                var karjeraCE = KarjerosEtapasRepo.FindKarjerosEtapasCE(id);
                PopulateLists(karjeraCE);

                return View("Delete", karjeraCE);
            }
        }
        private void PopulateLists(KarjerosEtapasCE karCE)
        {
            var zaidejai = ZaidejasRepo.ListZaidejas();
            var pareigos = PareigosRepo.List();

            karCE.Lists.Zaidejai =
                zaidejai.Select(it =>
                {
                    return
                        new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                        {
                            Value = Convert.ToString(it.Id),
                            Text = it.Vardas + " " + it.Pavarde
                        };
                }).ToList();

            karCE.Lists.Pareigos = pareigos.Select(it =>
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

}
