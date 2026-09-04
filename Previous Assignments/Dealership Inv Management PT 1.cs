// Used https://asciiflow.com/#/ for menu
using System.Data;
using System.Dynamic;
using System.Net.Security;
using System.Runtime.InteropServices.Marshalling;

string menu = """
    +---------------------------------------+
    |          Carls Cars and Stuff         |
    |                                       |
    |     Please Select an Option: (1-4)    |
    +---------------------------------------+
    |          1. View Inventory            |
    |                                       |
    |          2. Add Vehicle               |
    |                                       |
    |          3. Remove Vehicle            |
    |                                       |
    |          4. Quit                      |
    |                                       |
    +---------------------------------------+
""";

object[,] vehicles = new object[,]
{
    { 2022, "Hyundai", "Kona" },
    { 2020, "Ford", "F-150" },
    { 1967, "Chevorlet", "Impala" }
};

void PrintMenu()
{
    Console.WriteLine(menu);
}

int GetUserInput()
{
    string response = Console.ReadLine();
    int userSelection = 0;
    while (!int.TryParse(response, out userSelection))
    {
        Console.WriteLine("Invalid Option. Try Again.");
        response = Console.ReadLine();
    }
    return userSelection;    
}

void AddVehicle()
{
    Console.WriteLine("What is the Make?");
    string make = Console.ReadLine();
    Console.WriteLine("What is the Model?");
    string model = Console.ReadLine();
    Console.WriteLine("What is the year?");
    string yearResponse = Console.ReadLine();

    int year = 0;

    while (!int.TryParse(yearResponse, out year))
    {
        Console.WriteLine("Must be a number. What is the year?");
        yearResponse = Console.ReadLine();
    }

    int currentRows = vehicles.GetLength(0);

    object[,] newVehicles = new object[currentRows + 1, 3];

    for (int i = 0; i < currentRows; i++)
    {
        newVehicles[i, 0] = vehicles[i, 0];
        newVehicles[i, 1] = vehicles[i, 1];
        newVehicles[i, 2] = vehicles[i, 2];
    }
    newVehicles[currentRows, 0] = year;
    newVehicles[currentRows, 1] = make;
    newVehicles[currentRows, 2] = model;

    vehicles = newVehicles;
    Console.WriteLine("Vehicle added successfully! Returning to Menu...");
    Console.WriteLine(); 
    main();
}

void ViewInventory()
{
    for (int i = 0; i < vehicles.GetLength(0); i++)
    {
        object year = vehicles[i, 0];
        object make = vehicles[i, 1];
        object model = vehicles[i, 2];

        Console.WriteLine($"{i + 1}. {year} {make} {model}");
    }
}
void RemoveVehicle()
{
    ViewInventory();
    Console.WriteLine($"What vehicle would you like to remove? (1-{vehicles.Length/3})");
    string removal = Console.ReadLine();
    int vehicular = 0;

    if (!int.TryParse(removal, out vehicular))
    {
        Console.WriteLine("Invalid Input. Exiting Back to Menu.....");
        main();
        return;
    }
    else
    {
        int currentRows = vehicles.GetLength(0);
        vehicular -=1;

        object[,] newVehicles = new object[currentRows - 1, 3];
        int newRow = 0;
        for (int i = 0; i < currentRows; i++)
        {
            if (i == vehicular) {continue;}
            newVehicles[newRow, 0] = vehicles[i, 0];
            newVehicles[newRow, 1] = vehicles[i, 1];
            newVehicles[newRow, 2] = vehicles[i, 2];
            newRow++;
        }

        vehicles = newVehicles;
        Console.WriteLine("Vehicle removed successfully! Returning to menu...");
        Console.WriteLine(); 
        main();
    }
}


void HandleUserInput(int input)
{
    Console.WriteLine();
    switch (input)
    {
        case 1: 
            ViewInventory();
            main();
            break;
        case 2: 
            AddVehicle();
            break;
        case 3: 
            RemoveVehicle();
            break;
        case 4:
            break;
    }    
}

void main()
{
    PrintMenu();
    HandleUserInput(GetUserInput());
}

main();