
List<Product> products = new List<Product>()
{
    new Product() { Name = "Football", Price = 25, Sold = true, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010 },
    new Product() { Name = "Hockey Stick", Price = 50, Sold = false, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010 },
    new Product() { Name = "Boomerang", Price = 10, Sold = true, Gift = true, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010 },
    new Product() { Name = "Frisbee", Price = 15, Sold = true, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010 },
    new Product() { Name = "Golf Putter", Price = 75, Sold = false, Gift = false, StockDate = new DateTime(2022, 10, 20), ManufactureYear = 2010 }
};


// Display menu options from our list of products
Console.WriteLine("Products");
Console.WriteLine("Please enter a product number: ");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine();
int response = int.Parse(Console.ReadLine());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

DateTime now = DateTime.Now;


Product chosenProduct = products[response - 1];
//TimeSpan timeInStock = now - chosenProduct.StockDate;
//Console.WriteLine(@$"You chose: {chosenProduct.Name}, which cost ${chosenProduct.Price}
//dollars and is {(chosenProduct.Sold ? "" : "not ")}sold, and 
//will {(chosenProduct.Gift ? "" : "not ")}be a gift. This item has been in
//in stock for {timeInStock.Days} days.");

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");