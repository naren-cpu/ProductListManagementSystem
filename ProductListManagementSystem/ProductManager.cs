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

                Console.Write("Enter Product Name: ");
                string? productname = Console.ReadLine();

                if (productname == "q")
                    break;

                Console.Write("Enter Price: ");
                string? priceInput = Console.ReadLine();

                if (priceInput == "q")

                {
                    break;
                }


                decimal.TryParse(priceInput, out decimal price);



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

    }

}
    