using System.Collections.Generic;

namespace VendorAndOrder.Models
{
    public class Vendor 
    {
        public string Name;
        public string Description;
        public int Id;
        public List <Order> theOrders = new List<Order> {};
    }


}