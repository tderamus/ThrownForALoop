
List<Product> products = new List<Product>()
{
    new Product() { Name = "Football", Price = 25.00M, Sold = true, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010, Condition = 4.2  },
    new Product() { Name = "Hockey Stick", Price = 50.00M, Sold = false, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010, Condition = 4.2  },
    new Product() { Name = "Boomerang", Price = 10.00M, Sold = true, Gift = true, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010, Condition = 4.2  },
    new Product() { Name = "Frisbee", Price = 15.00M, Sold = true, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010, Condition = 4.2  },
    new Product() { Name = "Golf Putter", Price = 75.00M, Sold = false, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010, Condition = 4.2  }
};


// Display menu options from our list of products
Console.WriteLine("Products");
Console.WriteLine();
decimal totalValue = 0.0M;

foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");
Console.WriteLine();
Console.WriteLine("Please enter a product number: ");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Product chosenProduct = null;

while (chosenProduct == null)
{
    Console.WriteLine("\nPlease enter a product number: ");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    catch (FormatException)
    {
        Console.WriteLine("Please type only integers!");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Please choose an existing item only!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do Better!");
    }
}

DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;

Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");