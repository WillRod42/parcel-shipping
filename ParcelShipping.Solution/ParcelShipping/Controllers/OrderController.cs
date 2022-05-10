using Microsoft.AspNetCore.Mvc;
using ParcelShipping.Models;

namespace ParcelShipping.Controllers
{
	public class OrderController : Controller
	{
		[HttpGet("<insert route here>")]
		public ActionResult Index()
		{
			return View();
		}
	}
}
