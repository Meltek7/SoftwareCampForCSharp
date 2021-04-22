using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 300;
            product1.UnitsInStock = 24;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Defter", UnitPrice = 25, UnitsInStock = 12 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
