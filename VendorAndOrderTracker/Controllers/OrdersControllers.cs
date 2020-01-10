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
        public ActionResult Show(int vendorId, int orderId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order selectedOrder = Order.Find(orderId);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
  }
}
