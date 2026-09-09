using System.Runtime.CompilerServices;

public class Person 
{
    public string Name { get; set; }
    private static int _nextId;
    public int Id {get;}

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
        Id= _nextId;
        _nextId += 1;
    } 

    public Person Copy()
    {
        return new Person(this.Name, this.Age);
    }

    public override bool Equals(object obj)
    {
        Person other = (Person)obj;
        return this.Id == other.Id; 
    }

    public void HappyBirthday()
    {
        Age += 1;

        Console.WriteLine($"Happy Birthday, {Name}! You are now {Age} years old.");
    }

    public virtual void Introduce()
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

public class Student : Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    private List<int> _grades = new List<int>();
    public Student(string name, int age) : base(name,age)
    {
        Name = name;
        Age = age;
    }

    public double GetGPA()
    {
        double grade = 0;
        foreach (var grades in _grades)
        {
            if (grades >= 90)
                grade += 4.0;
            else if (grades >= 87)
                grade += 3.7;
            else if (grades >= 83)
                grade += 3.3;
            else if (grades >= 80)
                grade += 3.0;
            else if (grades >= 77)
                grade += 2.7;
            else if (grades >= 73)
                grade += 2.3;
            else if (grades >= 70)
                grade += 2.0;
            else if (grades >= 67)
                grade += 1.7;
            else if (grades >= 63)
                grade += 1.3;
            else if (grades >= 60)
                grade += 1.0;
        }

        return grade / _grades.Count;
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi my name is {Name} and I am {Age} years old. My GPA is {GetGPA()}");
    }

    public void AddGrade(int grade)
    {
        _grades.Add(grade);
    }

    
}