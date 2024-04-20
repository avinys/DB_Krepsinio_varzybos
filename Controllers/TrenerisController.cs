using Krepsinio_varzybos.Models;
using Krepsinio_varzybos.Repositories;
using Microsoft.AspNetCore.Mvc;

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
	}
}