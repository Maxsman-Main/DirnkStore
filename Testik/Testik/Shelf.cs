using System;
using System.Collections.Generic;
using System.Text;

namespace Testik
{
    public class Shelf
    {
        private List<Product> _products;

        public List<Product> Products => _products;
        public List<string> ProductsNames => GetProductsNames();

        public Shelf()
        {
            _products = new List<Product>() { new Product("Water", "water.png"), 
                                              new Product("Cola",  "cola.png"),
                                              new Product("Juice", "juice.png")};
        }

        public Product GetProductByID(int productID)
        {
            if(productID < 0 || productID > _products.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _products[productID];
        }

        private List<string> GetProductsNames()
        {
            List<string> productsNames = new List<string>();
            foreach(Product product in _products)
            {
                productsNames.Add(product.Name);
            }
            return productsNames;
        }
    }
}
