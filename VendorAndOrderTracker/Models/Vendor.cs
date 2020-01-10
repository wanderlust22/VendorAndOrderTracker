using System.Collections.Generic;

namespace VendorAndOrder.Models
{
    public class Vendor 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static List <Vendor> _instances = new List<Vendor> {};
        public List<Order> Orders { get; set; }

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> {};
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }
    }
}