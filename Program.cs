
List<Product> products = new List<Product>()
{
    new Product() { Name = "Football", Price = 25, Sold = false },
    new Product() { Name = "Hockey Stick", Price = 50, Sold = false },
    new Product() { Name = "Boomerang", Price = 10, Sold = false },
    new Product() { Name = "Frisbee", Price = 15, Sold = false },
    new Product() { Name = "Golf Putter", Price = 75, Sold = false }
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

Product chosenProduct = products[response - 1];
Console.WriteLine(@$"You chose: {chosenProduct.Name}, which cost ${chosenProduct.Price}
dollars and is {(chosenProduct.Sold ? "" : "not ")}sold ");