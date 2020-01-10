using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        return RedirectToAction("Index");
    }

  }
}