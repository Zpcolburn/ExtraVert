// See https://aka.ms/new-console-template for more information

using System;

List<Plant> plants = new List<Plant>()
{
    new Plant ()
    {
        Species = "Snake Plant",
        LightNeeds = 2,
        AskingPrice = 25,
        City = "Roseville",
        ZIP = 95661,
        Sold = false
    },
    new Plant ()
    {
        Species = "Spider Plant",
        LightNeeds = 3,
        AskingPrice = 19,
        City = "Columbia",
        ZIP = 38401,
        Sold = false
    },
    new Plant ()
    {
        Species = "Peace Lily",
        LightNeeds = 2,
        AskingPrice = 31,
        City = "Franklin",
        ZIP = 37027,
        Sold = false
    },
    new Plant ()
    {
        Species = "Fiddle Leaf Fig",
        LightNeeds = 4,
        AskingPrice = 143,
        City = "Nashville",
        ZIP = 37011,
        Sold = false
    },
    new Plant ()
    {
        Species = "Aloe Vera",
        LightNeeds = 4,
        AskingPrice = 12,
        City = "Nolensville",
        ZIP = 37135,
        Sold = false
    },

};

string greeting = @"Welcome to Extravert where, you guessed it, extraverts come to buy their favorite thing...... plants!";

Console.WriteLine(greeting);

Console.WriteLine("Please choose a species name: ");

string response = Console.ReadLine();

while (string.IsNullOrEmpty(response))
{
    Console.WriteLine("You didn't choose anything, try again!");
    response = Console.ReadLine();
}

Console.WriteLine($"You chose: {response}");

Console.WriteLine("Available Plants:");
for (int i = 0; i < plants.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plants[i].Species}");
}
