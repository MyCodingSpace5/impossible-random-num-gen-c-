Random rnd = new Random();
var lk = rnd.Next();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the number");
Console.WriteLine(lk);
var l = Console.ReadLine();
int lp = int.Parse(l);
if (lp > lk)
{
    Console.WriteLine("Too high");
}
if(lp < lk)
{
    Console.WriteLine("Too low");
}
if(lp == lk)
{
    Console.WriteLine("Just right!");
}
