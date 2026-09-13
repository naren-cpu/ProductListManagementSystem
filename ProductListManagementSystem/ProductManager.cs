using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductListManagementSystem
{
    public class ProductManager

    {
        List<Product> products = new List<Product>();

        public void AddProduct()
        {

            while (true)
            {

                Console.Write("Enter Category: ");
                string? category = Console.ReadLine();

                if (category == "q")
                    break;

                if(string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("ERROR: Category cannot be empty.");
                    continue;
                }

                Console.Write("Enter Product Name: ");
                string? productname = Console.ReadLine();

                if (productname == "q")
                    break;

                if (string.IsNullOrWhiteSpace(productname))
                {
                    Console.WriteLine("ERROR: Product name cannot be empty.");
                    continue;
                }

                Console.Write("Enter Price: ");
                string? priceInput = Console.ReadLine();

                if (priceInput == "q")

                {
                    break;
                }


                if (!decimal.TryParse(priceInput, out decimal price))
                {
                    Console.WriteLine("ERROR: Invalid price. Please enter a numeric value.");
                    continue;
                }

                if (price < 0)
                {
                    Console.WriteLine("ERROR: Price cannot be negative.");
                    continue;
                }



                Product product1 = new Product();

                product1.Category = category;
                product1.ProductName = productname;
                product1.Price = price;

                products.Add(product1);

                Console.WriteLine();
                Console.WriteLine("Product added successfully!");
                Console.WriteLine();


            }


        }

        public void ShowProducts()
        {


            var sorted = products.OrderBy(p => p.Price).ToList();


            Console.WriteLine("===== PRODUCT LIST =====");

            foreach (Product product in sorted)
            {
                Console.WriteLine($"{product.Category} | {product.ProductName} | {product.Price} kr");
            }


        }



        public decimal CalculateTotal()
        {
            return products.Sum(p => p.Price);
        }

        public void SearchProduct()
        {
            Console.Write("Search Product: ");
            string? search = Console.ReadLine();

            var results = products.Where(p =>
                p.ProductName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                p.Category.Contains(search, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine();
            Console.WriteLine("FOUND PRODUCTS:");

            foreach (Product product in results)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(
                    $"{product.Category} | {product.ProductName} | {product.Price} kr");

                Console.ResetColor();
            }
        }

    }




}
    