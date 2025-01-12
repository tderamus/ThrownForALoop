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

int response = int.Parse(Console.ReadLine().Trim());
