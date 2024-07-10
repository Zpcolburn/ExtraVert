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

string greeting = @"Welcome to Extravert, the only plant adobtion store!";

Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
                        0. Exit
                        1. Display all plants
                        2. Post a plant to be adobted
                        3. Adopt a plant
                        4. Delist a plant");
    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodby!");
    }
    else if (choice == "1")
    {
        throw new NotImplementedException("DisplayPlants");
    }
    else if (choice == "2")
    {
        throw new NotImplementedException("PostPlantToBeAdobted");
    }
    else if (choice == "3")
    {
        throw new NotImplementedException("AdoptPlant");
    }
    else if (choice == "4")
    {
        throw new NotImplementedException("DelistPlant");
    }
};
Console.Read();