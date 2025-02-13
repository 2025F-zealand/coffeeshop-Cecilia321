// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

Latte l = new Latte();
Cortado c = new Cortado();
BlackCoffee b = new BlackCoffee();
//Console.WriteLine(l.Price() + l.Strength() + l.MlMilk());


List<Coffee> list = new List<Coffee>();
list.Add(l);
list.Add(c);
list.Add(b);

foreach (Coffee co in list)
{
    Console.WriteLine(co.Price() + co.Strength());
}


