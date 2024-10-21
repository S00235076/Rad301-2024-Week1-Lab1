using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Rad301_2024_Week1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            List<int> productIDs = new List<int> { 1, 2, 3, 4 };
            List<string> descriptions = new List<string> { "9 inch nails", "9 inch bolts", "Chimney Hoover", "Washing Machine" };
            List<int> quantities = new List<int> { 200, 120, 10, 7 };
            List<float> unitPrices = new List<float> { 0.1f, 0.2f, 100.30f, 399.50f };
            List<int> categoryIDs = new List<int> { 1, 1, 2, 2 };

            List<int> cID = new List<int> { 1, 2 };
            List<string> cDescription = new List<string> { "Hardware", "Electrical Appliances" };

            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier { SupplierID = 1, SupplierName = "ABC Supplies" },
                new Supplier { SupplierID = 2, SupplierName = "XYZ Industries" }
            };

            List<SupplierProduct> supplierProducts = new List<SupplierProduct>
            {
                new SupplierProduct { SupplierID = 1, ProductID = 1 },
                new SupplierProduct { SupplierID = 1, ProductID = 2 },
                new SupplierProduct { SupplierID = 2, ProductID = 3 },
                new SupplierProduct { SupplierID = 2, ProductID = 4 }
            };


            List<Category> categories = new List<Category>();
            for (int i = 0; i < cID.Count; i++)
            {
                categories.Add(new Category
                {
                    CategoryID = cID[i],
                    CategoryDescription = cDescription[i]
                });
            }

            List<Product> products = new List<Product>();
            for (int i = 0; i < productIDs.Count; i++)
            {
                products.Add(new Product
                {
                    ProductID = productIDs[i],
                    Description = descriptions[i],
                    QuantityInStock = quantities[i],
                    UnitPrice = unitPrices[i],
                    CategoryID = categoryIDs[i]
                });
            }

            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryID}, Description: {category.CategoryDescription}");
            }
            Console.WriteLine();

            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                var category = categories.Find(c => c.CategoryID == product.CategoryID);
                Console.WriteLine($"ID: {product.ProductID}, Description: {product.Description}, Category: {category?.CategoryDescription}, Price: {product.UnitPrice:C}, Stock: {product.QuantityInStock}");
            }
            Console.WriteLine();  

            Console.WriteLine("Products with Quantity <= 100:");
            foreach (var product in products)
            {
                if (product.QuantityInStock <= 100)
                {
                    var category = categories.Find(c => c.CategoryID == product.CategoryID);
                    Console.WriteLine($"ID: {product.ProductID}, Description: {product.Description}, Category: {category?.CategoryDescription}, Price: {product.UnitPrice:C}, Stock: {product.QuantityInStock}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Products with Quantity > 120:");
            var highQuantityProducts = products.Where(p => p.QuantityInStock > 120);
            foreach (var product in highQuantityProducts)
            {
                Console.WriteLine($"ID: {product.ProductID}, Description: {product.Description}, Stock: {product.QuantityInStock}");
            }
            Console.WriteLine();

            Console.WriteLine("Products with their Total Value:");
            foreach (var product in products)
            {
                float totalValue = product.QuantityInStock * product.UnitPrice;
                Console.WriteLine($"Product: {product.Description}, Total Value: {totalValue:C}");
            }
            Console.WriteLine();

            Console.WriteLine("Products in the Hardware Category:");
            var hardwareProducts = from p in products
                                   join c in categories on p.CategoryID equals c.CategoryID
                                   where c.CategoryDescription == "Hardware"
                                   select p;

            foreach (var product in hardwareProducts)
            {
                Console.WriteLine($"ID: {product.ProductID}, Description: {product.Description}, Stock: {product.QuantityInStock}");
            }
            Console.WriteLine();

            Console.WriteLine("Suppliers and their Parts (ordered by Supplier name):");
            var supplierParts = from sp in supplierProducts
                                join s in suppliers on sp.SupplierID equals s.SupplierID
                                join p in products on sp.ProductID equals p.ProductID
                                orderby s.SupplierName
                                select new { s.SupplierName, p.Description };

            foreach (var item in supplierParts)
            {
                Console.WriteLine($"Supplier: {item.SupplierName}, Part: {item.Description}");
            }
        }
    }
}


