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

Random random = new Random();
 
string greeting = @"Welcome to Extravert, the only plant adoption store!";
Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
                        0. Exit
                        1. Display all plants
                        2. Post a plant to be adopted
                        3. Adopt a plant
                        4. Delist a plant
                        5. Plant of the Day");

    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
       DisplayPlants();
    }
    else if (choice == "2")
    {
        PostPlantToBeAdopted();
    }
    else if (choice == "3")
    {
        AdoptPlant();
    }
    else if (choice == "4")
    {
        DelistAPlant();
    }
    else if (choice == "5")
    {
        PlantOfTheDay();
    }
};

void DisplayPlants()
{
    for (int i = 0; i < plants.Count; i++)
    {
        string status = plants[i].Sold ? "was sold" : "is available";
        Console.WriteLine($"{i + 1}. A {plants[i].Species} in {plants[i].City} {status} for {plants[i].AskingPrice} dollars");
    }
};

void PostPlantToBeAdopted()
{
    // Take input as string for a plant species to be added 
    Console.WriteLine("Enter the plant species:");
    string species = Console.ReadLine();

    // Initailizes lightNeeds to 0
    int lightNeeds = 0;
    // Prompts a message to the console asking for input
    Console.WriteLine("Enter the light needs (1-5):");
    // This attempts to convert the users input to a integer, if successfull it assigns it to lightNeeds and returns true. 
    // lightNeeds < 1 || lightNeeds > 5 This checks if the integer is within (1-5)
    while(!int.TryParse(Console.ReadLine(), out lightNeeds) || lightNeeds < 1 || lightNeeds > 5)
    {
        // If false this is the message that gets sent to console
        Console.WriteLine("Please enter number between 1 and 5 for light needs:");
    }
    // Message asking user to input the price. 
    Console.WriteLine("Enter the asking price:");
    int askingPrice;
    // This converts users input to an integer and makes them put in a price greater than zero
    while (!int.TryParse(Console.ReadLine(), out askingPrice) || askingPrice < 0)
    {
        // If user inputs negative numbers it will throw this code to console
        Console.WriteLine("Please enter a valid positive number for the asking price:");
    }
    // Message asking for users input
    Console.WriteLine("Enter the city:");
    // Reads user input as a string
    string city = Console.ReadLine();

    // Message asking for users input
    Console.WriteLine("Enter the ZIP code:");
    int zip;
    // Once again taking users input coverting to a integer and checking that its greater than 10000 and under 99999
    // This keeps them in the 5 number format 
    while (!int.TryParse(Console.ReadLine(), out zip) || zip < 10000 || zip > 99999)
    {
        // if false it throws this message prompting user to try again 
        Console.WriteLine("Please enter a valid 5-digit ZIP code:");
    }

    Plant newPlant = new Plant()
    {
        Species = species,
        LightNeeds = lightNeeds,
        AskingPrice = askingPrice,
        City = city,
        ZIP = zip,
        Sold = false
    };
   
    plants.Add(newPlant);
    
    Console.WriteLine("Plant added successfully!");
}

void AdoptPlant()
{
    Console.WriteLine("Plants available for adoption:");
    List<Plant> availablePlants = plants.FindAll(plant => !plant.Sold);
    for(int i = 0; i < availablePlants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. A {plants[i].Species} in {plants[i].City} is available for {plants[i].AskingPrice} dollars");
    }
    if (availablePlants.Count == 0)
    {
        Console.WriteLine("There are no available plants to adopt");
        return;
    }
    Console.WriteLine("Please enter the number of the plant you want to adopt:");
    int choice;
    while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > availablePlants.Count)
    {
        Console.WriteLine("Please enter corresponding number to the plant");
    }

    availablePlants[choice - 1].Sold = true;
    Console.WriteLine("Thank you for adopting a plant");
}

void DelistAPlant()
{
    Console.WriteLine("All plants");
    for (int i = 0; i < plants.Count; i++)
    { 
        Console.WriteLine($"{i + 1}. A {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice} dollars");
    }
    if (plants.Count == 0)
    {
        Console.WriteLine("No plants to delist.");
        return;
    }

    Console.WriteLine("Please enter the number of the plant you want to delist:");
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > plants.Count)
    {
        Console.WriteLine("Please enter corresponding number to the plant:");
    }
}

void PlantOfTheDay()
{
    Plant randomPlant = null;
    while(randomPlant == null)
    {
        int randomIndex = random.Next(plants.Count);
        if(!plants[randomIndex].Sold)
        {
            randomPlant = plants[randomIndex];
        }
         
    }
    Console.WriteLine($"Plant of the day: {randomPlant.Species}, located in {randomPlant.City} Zip code is {randomPlant.ZIP}, require light level {randomPlant.LightNeeds}, priced at {randomPlant.AskingPrice} dollars");
}

