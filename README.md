# Product List Management System

A C# Console Application developed as a learning project to practice object-oriented programming, collections, LINQ, validation, error handling, and basic product management functionality.

The project is developed progressively through four levels, with each level adding new functionality and improving the application structure.

---

## Project Overview

The Product List Management System allows users to manage products through a console-based interface.

Each product contains:

- Category
- Product Name
- Price

The application demonstrates how a simple product list can be gradually developed into a more structured inventory management system.

---

## Technologies Used

- C#
- .NET
- Visual Studio
- Git & GitHub
- LINQ
- Console Application

---

# Project Levels

## Level 1 – Basic Product List

The first level focuses on the fundamentals of C# and object-oriented programming.

### Features

- Create a `Product` class
- Store products in a `List<Product>`
- Add products dynamically
- Store:
  - Category
  - Product Name
  - Price
- Display all added products
- Allow the user to exit by entering `q`

### Concepts Practiced

- Classes
- Objects
- Properties
- Lists
- Loops
- User input
- Basic console output

---

## Level 2 – Multiple Classes & Price Summary

Level 2 introduces better application structure by separating product data from product management.

### Features

- Added `ProductManager` class
- Add products using `AddProduct()`
- Display products using `ShowProducts()`
- Calculate total price using `CalculateTotal()`
- Sort products from lowest to highest price
- Display total product price

### LINQ Used

- `OrderBy()`
- `Sum()`

### Concepts Practiced

- Multiple classes
- Methods
- Object-oriented design
- LINQ
- Collections
- Returning values from methods

---

## Level 3 – Error Handling & Dynamic Product Management

Level 3 focuses on making the application safer and more user-friendly.

### Features

- Validate empty category input
- Validate empty product name
- Validate numeric price input
- Prevent negative prices
- Display meaningful error messages
- Allow users to continue entering products after invalid input
- Continue managing products dynamically

### LINQ Used

- `OrderBy()`
- `Sum()`
- `Where()`

### Concepts Practiced

- `TryParse()`
- `continue`
- `break`
- Input validation
- Error handling
- LINQ filtering

---

## Level 4 – Search & Highlight Feature

Level 4 extends the application with product searching and console highlighting.

### Features

- Search products by product name
- Search products by category
- Case-insensitive searching
- Display matching products
- Highlight found products using console colors

### LINQ Used

- `Where()`

### Console Features

```csharp
Console.ForegroundColor = ConsoleColor.Green;
Console.ResetColor();
