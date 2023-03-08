using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    internal class Shop
    {
        public string Name { get; set; }
        Product[] products;
        public Shop()
        {
            products = new Product[0]; 
        }
        public void CreateProduct()
        {
            Product product =new Product("test");
            Array.Resize(ref products, products.Length+1);
            products[products.Length-1] = product;
            
            

        }
    }
}
         public void ShowProduct()
         



    foreach (var item in products)
    {
        Console.WriteLine($"Name: {item.Name}");
    }
