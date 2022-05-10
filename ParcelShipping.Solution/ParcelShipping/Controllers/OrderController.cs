using Microsoft.AspNetCore.Mvc;
using ParcelShipping.Models;

namespace ParcelShipping.Controllers
{
	public class OrderController : Controller
	{
		[HttpGet("/order")]
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost("/order/new")]
		public ActionResult OrderDetails(int weight, int width, int height, int length)
		{
			Parcel parcel = new Parcel(weight, width, height, length);
			return View(parcel);
		}
	}
}
