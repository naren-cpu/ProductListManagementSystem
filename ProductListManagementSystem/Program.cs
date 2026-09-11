/*
Console.WriteLine("-------------------------------");
Console.WriteLine("LEVEL 1");
Console.WriteLine("-------------------------------");
*/


Console.WriteLine("==== PRODUCT LIST APPLICATION ====");

List<Product> products = new List<Product>();
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

Console.WriteLine();
Console.WriteLine("===== PRODUCT LIST =====");
Console.WriteLine();


foreach (Product product in products)
{
    Console.WriteLine(
        $"{product.Category} | {product.ProductName} | {product.Price} kr"
    );
}

