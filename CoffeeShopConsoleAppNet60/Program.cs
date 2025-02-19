// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

Latte l = new Latte(4);
Cortado c = new Cortado();
BlackCoffee b = new BlackCoffee();
//Console.WriteLine(l.Price() + l.Strength() + l.MlMilk());

List<IMilk> milkList = new List<IMilk>();
milkList.Add(new Cortado());




List<Coffee> list = new List<Coffee>();
list.Add(l);
list.Add(c);
list.Add(b);
//list.Add(new Cortado());


foreach (Coffee co in list)
{ 

   if (co is IMilk)
    {
        Console.WriteLine($"Kaffens pris er {co.Price()}\nStyrken på kaffen: {co.Strength()} \nKaffens Mælkeindhold {(co as IMilk).MlMilk()}ml.\n"); //Ved at skrive as - kan vi nu få adgang til metoden i dette interface som vi ikke kan få adgang til igennem coffee objektet. 
        //Console.WriteLine((co as IMilk).MlMilk());
    }
    else
    {
        Console.WriteLine($"Kaffens pris er {co.Price()}\nStyrken på kaffen: {co.Strength()}");
    }
    
}


