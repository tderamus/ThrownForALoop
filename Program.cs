
using System.Threading.Channels;

string greeting = @"Welcom to Thrown For a Loop
your one-stop shop for used sporting equipment";
Console.WriteLine(greeting);


Console.WriteLine(@"Products:
    1. Football
    2. Hockey stick
    3. Boomeranng
    4. Frisbee
    5. Golf Putter");
Console.WriteLine("Please enter a product number:");

int response = int.Parse(Console.ReadLine().Trim());


// Verify the user entered a value that evaluates to true or false
while ( response > 5 || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}
Console.WriteLine($"You chose: {response}");

