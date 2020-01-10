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

    [HttpGet("/vendor/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(vendorId);
        List<Order> vendorOrders = selectedVendor.Orders;
        model.Add("vendor", selectedVendor);
        model.Add("orders", vendorOrders);
        return View(model);
    }

    [HttpPost("/vendor/{vendorId}")]
    public ActionResult Show(int vendorId, string orderTitle, string orderDescription, int orderPrice, int orderDate)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Order newOrder = new Order( orderTitle,  orderDescription,  orderPrice,  orderDate);
        Vendor selectedVendor = Vendor.Find(vendorId);
        selectedVendor.AddOrder(newOrder);
        List<Order> vendorOrders = selectedVendor.Orders;
        model.Add("vendor", selectedVendor);
        model.Add("orders", vendorOrders);
        return View("Show", model);

    }

  }
}