using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      return View();
    }

  }
}