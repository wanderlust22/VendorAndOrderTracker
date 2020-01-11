using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class OrderController : Controller
  {
        [HttpGet("/vendor/{vendorId}/order/new")]
        public ActionResult New(int vendorId)
        {
        Vendor vendor = Vendor.Find(vendorId);
        return View(vendor);
        }

        [HttpGet("/vendor/{vendorId}/order/{orderId}")]
        public ActionResult Show(int orderId)
        {
            Order selectedOrder = Order.Find(orderId);
            return View(selectedOrder);
        }
  }
}
