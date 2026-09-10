// Used https://asciiflow.com/#/ for menu
using System.ComponentModel.DataAnnotations;
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

Vehicle[] inv = new Vehicle[3]{new Car(2021,"Hyundai","Kona"), new Truck(2006,"Ford","F-150",6),new Car(2003,"Saturn","L200")};

var inventory = new Inventory("Carls Cars and Stuff", inv);

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

void AskForCar(string mode)
{
    if (mode == "Add") {
    int type = 0;
    Console.WriteLine("Type 1 for Car, 2 for Truck");
    switch (GetUserInput()) {
        case 1:
            type = 1;
            break;
        case 2:
            type = 2;
            break; 
    }

    Console.WriteLine("What is the Year?");
    int year = GetUserInput();
    Console.WriteLine("Who is the Make?");
    string make = Console.ReadLine();
    Console.WriteLine("What is the Model?");
    string model = Console.ReadLine();
    if (type == 2)
    {
        double truckBed = 0;
        Console.WriteLine("To the nearest decimal, what is the truck bed in feet?");
        truckBed = GetUserInput();
        inventory.addCar(new Truck(year,make,model,truckBed));
    }
    inventory.addCar(new Car(year,make,model));
    }

    else if(mode == "Remove")
    {
        int index;
        Console.WriteLine(inventory.ToString());
        Console.WriteLine();
        Console.WriteLine("What is the index of car to remove?");
        index = GetUserInput();
        inventory.removeCar(index);
    }

}
void HandleUserInput(int input)
{
    Console.WriteLine();
    switch (input)
    {
        case 1: 
            Console.WriteLine(inventory.ToString());
            main();
            break;
        case 2:
            AskForCar("Add");
            main();
            break;
        case 3:
            AskForCar("Remove");
            main();
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