


var r = new Random();
var favNumber = r.Next(1, 1000);
Console.WriteLine("Try to guess my fav number between 1 thru 1,000");
var userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber)
{
    Console.WriteLine("Too low");
}
else if (userInput > favNumber)
{
    Console.WriteLine("Too high");
}
else if(userInput == favNumber)
{
    Console.WriteLine("BANG, BANG! YOU ARE CORRECT!!!");
}
else
{
    Console.WriteLine("Nevermind...");
}

