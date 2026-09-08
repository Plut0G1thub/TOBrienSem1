using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
public class Person 
{
    public string Name { get; set; }
    
    private int _age;
    public int Age 

    
    { 
        get => _age; 
        set 
        { 
            if (value < 0) 
            { 
                throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative."); 
            } 
            _age = value; 
        } 
    } 
    public bool isAdult => Age >= 18; 

    public Person(string name, int age) 
    { 
        Name = name; 
        Age = age; 
    } 

    public void HappyBirthday()
    {
        Age += 1;

        Console.WriteLine($"Happy Birthday, {Name}! You are now {Age} years old.");
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi my name is {Name} and I am {Age} years old.");
    }

    public static void GreetAll(List<Person> people)
    {
        foreach (var person in people)
        {
            person.Introduce();
        }
    }

    public override string ToString()
    {
        return $"{Name}, {Age}";
    }

    public bool isOlderThan(Person other)
    {
        return Age > other.Age;
    }
}