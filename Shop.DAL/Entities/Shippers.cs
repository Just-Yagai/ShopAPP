using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Shippers : Person
    {
        public int ShipperId { get; set; }
        public string? Name { get; set; } 
    }
}
