/* ~~~~~~~~~~~ Exercise 1: Seating Arrangement ~~~~~~~~~~~ */
using System.IO.Compression;
using System.Reflection.Metadata;

Console.WriteLine("Theatre Seating Arrangement");
for (int row = 1; row <= 5 ; row++)
{
    string seatsInRow = "";

    for (int seat = 1; seat <= 10; seat++)
    {
        seatsInRow += $"{row}-{seat} ";
        
    }
    Console.WriteLine(seatsInRow);
}
/* ~~~~~~~~~~~ Exercise 2: Simple Interest Calculator ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Simple Interest Calculation:");

int principle = 1000;
int rate = 5;
int years = 1;

while(years <=5)
{
    int interest = (principle * rate * years) / 100;
    Console.WriteLine($"Year {years} : ${interest}");
    years +=1;
}
/* ~~~~~~~~~~~ Exercise 3: Prime Numbers ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Prime Numbers Between 2 and 30:");
for (int num = 2; num <= 30; num ++)
{
    bool isPrime = true;
    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(num);
    }
}

/* ~~~~~~~~~~~ Exercise 4: Prime Numbers in reverse ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Prime Numbers Between 20 and 1:");
for (int num = 20; num >= 1; num --)
{
    bool isPrime = true;
    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(num);
    }
}

/* ~~~~~~~~~~~ Exercise 5: Simple Login ~~~~~~~~~~~ */
string correct_username = "awesome_user_42";
string correct_password = "p455w0rd";

Console.WriteLine("Enter your username:");
string username = Console.ReadLine();
Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

while (correct_username != username && correct_password != password)
{
    Console.WriteLine();
    Console.WriteLine("Incorrect. Try again");
    Console.WriteLine();

    Console.WriteLine("Enter your username:");
    username = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    password = Console.ReadLine();
}

Console.WriteLine("Logged In.");

/* ~~~~~~~~~~~ Exercise 6: Iterate Over an Array ~~~~~~~~~~~ */
string[] someStrings = ["This", "is", "an", "array", "of", "strings", "let's", "iterate", "over", "it!"];
string forEachString = "";
foreach (string aString in someStrings)
{
    forEachString += $"{aString} ";
}
Console.WriteLine(forEachString);