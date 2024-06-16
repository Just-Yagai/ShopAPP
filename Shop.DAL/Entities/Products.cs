using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Products : BaseEntity
    {
        public int ProductsId { get; set; }
        public string? ProductName { get; set; }
        public string? SupplierId { get; set; }
        public string? CategoryId { get; set; } 
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
