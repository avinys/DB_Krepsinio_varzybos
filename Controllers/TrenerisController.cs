using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;
using static Krepsinio_varzybos.Models.TrenerisCE;

namespace Krepsinio_varzybos.Controllers
{
	public class TrenerisController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			var treneriai = TrenerisRepo.List();
			return View(treneriai);
		}
        [HttpGet]
		public ActionResult Create()
		{
			var treneris = new TrenerisCE();
            PopulateLists(treneris);
			return View(treneris);
		}
        [HttpPost]
        public ActionResult Create(TrenerisCE trenerisCE)
        {
            if (ModelState.IsValid)
            {
                TrenerisRepo.Insert(trenerisCE);
                return RedirectToAction("Index");
            }
            PopulateLists(trenerisCE);
            return View(trenerisCE);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var treneris = TrenerisRepo.FindTrenerisCE(id);
            PopulateLists(treneris);
            return View(treneris);
        }

        [HttpPost]
        public ActionResult Edit(int id, TrenerisCE trenerisCE)
        {
            if (ModelState.IsValid)
            {
                TrenerisRepo.Update(trenerisCE);
                return RedirectToAction("Index");
            }
            PopulateLists(trenerisCE);
            return View(trenerisCE);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var treneris = TrenerisRepo.FindTrenerisCE(id);
            PopulateLists(treneris);
            return View(treneris);
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                TrenerisRepo.Delete(id);
                return RedirectToAction("Index");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                ViewData["deletionNotPermitted"] = true;

                var treneris = TrenerisRepo.FindTrenerisCE(id);
                PopulateLists(treneris);
                return View("Delete", treneris);
            }
        }
        private void PopulateLists(TrenerisCE treCE)
        {
            var komandos = KomandaRepo.List();
            treCE.Lists.Komandos = komandos.Select(it =>
            {
                return new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = Convert.ToString(it.Id),
                    Text = it.Pavadinimas
                };
            }).ToList();
        }
    }
}