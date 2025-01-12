List<int> years = new List<int> 
{ 
    2010, 
    2011, 
    2012, 
    2013, 
    2014, 
    2015, 
    2016, 
    2017, 
    2018, 
    2019, 
    2020 
};

List<String> products = new List<String>()
{
    "Football",
    "Hockey Stick",
    "Boomerang",
    "Fresbee",
    "Golf Putter"
};

// Display menu options from our list of products
Console.WriteLine("Products");
Console.WriteLine("Please enter a product number: ");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i]}");
}

int response = int.Parse(Console.ReadLine());

// Verify the user entered a value that evaluates to true or false
while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}
Console.WriteLine($"You chose: {products[response -1]}");