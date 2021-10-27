using System;

Console.WriteLine("Aston Martin Store");
Console.WriteLine();
Console.WriteLine("Press 'Enter' to continue to store");

Console.ReadLine();
Console.Clear();

int money = 100;

while (money > 0)
{

    string answer1 = "";

    Console.WriteLine("a) Aston Martin DB5");
    Console.WriteLine("25");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("b) Aston Martin DBS");
    Console.WriteLine("20");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("c) Aston Martin V8");
    Console.WriteLine("10");
    Console.WriteLine();
    Console.WriteLine();

    answer1 = Console.ReadLine().ToLower();
    Console.Clear();

    string numText = Console.ReadLine();
    int num;
    int.TryParse(numText, out num);

    if (answer1 == "a")
    {
        if (25 * num <= money)
        {
            Console.WriteLine("You bought the Aston Martin DB5");
            money = money - 25 * num;
        }
        else
        {
            Console.WriteLine("You did not have enough money to buy");
        }
        Console.ReadLine();
    }
    else if (answer1 == "b")
    {
        if (20 * num <= money)
        {
            Console.WriteLine("You bought the Aston Martin DBS");
            money = money - 20 * num;
        }
        else
        {
            Console.WriteLine("You did not have enough money to buy");
        }
        Console.ReadLine();
    }
    else if (answer1 == "c")
    {
        if (10 * num <= money)
        {
            Console.WriteLine("You bought the Aston Martin V8");
            money = money - 10 * num;
        }
        else
        {
            Console.WriteLine("You did not have enough money to buy");
        }
        Console.ReadLine();
    }

    Console.Clear();

    Console.WriteLine($"You have: {money}");
    Console.WriteLine("Press 'Enter' to Continue");

    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine($"You are out of money: {money}");
Console.WriteLine("Have a Nice Day");
Console.WriteLine();
Console.WriteLine("Press 'Enter' to Exit");

Console.ReadLine();