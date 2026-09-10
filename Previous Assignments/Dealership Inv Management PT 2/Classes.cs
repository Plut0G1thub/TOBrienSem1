using System.IO.Compression;
using System.Runtime.CompilerServices;

public class Vehicle
{
    public int Year {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}


    public Vehicle(int year, string make, string model)
    {
        Year = year;
        Make = make;
        Model = model;
    }
    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

public class Car : Vehicle
{
    public Car(int year, string make, string model) : base(year, make, model)
    {
        Year = year;
        Make = make;
        Model = model;
    }
}

public class Truck : Vehicle
{
    private double _bed {get;}
    public Truck(int year, string make, string model, double bed) : base(year, make, model)
    {
        Year = year;
        Make = make;
        Model = model;
        _bed = bed;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model} | Bed Length: {_bed}ft";
    }
}

public class Inventory
{
    private Vehicle[] inventory {get; set;}
    private string dealership {get;}

    public void addCar(Vehicle vehicular)
    {
        
        int currentRows = inventory.GetLength(0);

        Vehicle[] newInventory = new Vehicle[currentRows + 1];

        for (int i = 0; i < currentRows; i++)
        {
            newInventory[i] = inventory[i];
        }
        newInventory[currentRows] = vehicular;

        inventory = newInventory;
    }

    public void removeCar(int index)
    {
        int currentRows = inventory.GetLength(0);

        Vehicle[] newInventory = new Vehicle[currentRows - 1];

        for (int i = 0; i < currentRows; i++)
        {
            if (i == index-1)
            {
                continue;
            }
            newInventory[i] = inventory[i];
        }
        inventory = newInventory;
    }

    public override string ToString()
    {
        string inv = "";
        int index = 0;
        foreach(var vehicluar in inventory)
        {
            index += 1;
            inv += $"{index}. {vehicluar.ToString()} \n";
        }
        return inv;
    }

    public Inventory(string dealershipName, Vehicle[] carObj)
    {
        dealership = dealershipName;
        inventory = carObj;
    }
}