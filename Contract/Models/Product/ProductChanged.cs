using Contract.Enums.Product;

namespace Contract.Models.Product
{
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }
    }
}
