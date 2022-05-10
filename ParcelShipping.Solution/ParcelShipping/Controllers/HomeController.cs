using Microsoft.AspNetCore.Mvc;
using ParcelShipping.Models;

namespace ParcelShipping.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
