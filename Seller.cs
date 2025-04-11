using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Seller : User
    {
        public List<Product> Products { get; set; } = new();

        public void AddProduct(Product product)
        {
            product.Seller = this;
            Products.Add(product);
        }

        public override string GetDetails()
        {
            return $"Продавец: {Name}, Email: {Email}, Товаров: {Products.Count}";
        }
    }
}
