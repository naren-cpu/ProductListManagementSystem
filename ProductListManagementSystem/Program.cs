using ProductListManagementSystem;

Console.WriteLine("-------------------------------");
Console.WriteLine("LEVEL 4");
Console.WriteLine("-------------------------------");

Console.WriteLine("==== PRODUCT LIST APPLICATION ====");
Console.WriteLine();

// Create ProductManager
ProductManager manager = new ProductManager();

// Add products
manager.AddProduct();

// Display products sorted by price
manager.ShowProducts();

// Search Product
manager.SearchProduct();

// Calculate and display total
decimal total = manager.CalculateTotal();

Console.WriteLine();
Console.WriteLine($"TOTAL PRICE: {total} kr");