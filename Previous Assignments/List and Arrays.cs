/* ~~~~~~~~~~~ Exercise 1: Simple Array Operations ~~~~~~~~~~~ */
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

int[] fiver = new int[5]{1, 2, 3, 4, 5};

for (int i = 0; i < fiver.Length; i++)
{
    Console.WriteLine(fiver[i]);
}

/* ~~~~~~~~~~~ Exercise 2: Sum of Elements ~~~~~~~~~~~ */
Console.WriteLine();

string userInput = "";
int num = 0;
int[] elements = new int[5];
int sum = 0;

for (int i = 0; i<5;i++)
{
    Console.WriteLine($"Enter a number: ({i+1}/5)");
    userInput = Console.ReadLine();

    if (int.TryParse(userInput, out num))
    {
        elements[i] = num;
    }
    else
    {
        Console.WriteLine("Invalid. Try Again.");
        i -= 1;
    }
}

for (int i = 0; i < elements.Length; i++)
{
    sum += elements[i];
}

Console.WriteLine($"The sum of the numbers you provided is {sum}");

/* ~~~~~~~~~~~ Exercise 3: List of Strings ~~~~~~~~~~~ */

List<string> names = new List<string>();


for (int i = 0; i<5;i++)
{
    Console.WriteLine($"Please input a name: ({i+1}/5)");
    userInput = Console.ReadLine();

    if (userInput == "")
    {
        Console.WriteLine("Name cannot be empty.");
        i -= 1;
    }
    else
    {
        names.Add(userInput);
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

/* ~~~~~~~~~~~ Exercise 4: Sorting a List ~~~~~~~~~~~ */

List<string> words = new List<string>{"frank", "jinx", "lollygagging", "perposterous", "arcane"};
List<int> mumbers = new List<int>{2,45,1,6,7};

foreach (var word in words)
{
    Console.WriteLine(word);
}

foreach (var mum in mumbers)
{
    Console.WriteLine(mum);
}

words.Sort();
mumbers.Sort();

foreach (var word in words)
{
    Console.WriteLine(word);
}

foreach (var mum in mumbers)
{
    Console.WriteLine(mum);
}

/* ~~~~~~~~~~~ Exercise 5: Sorting a List ~~~~~~~~~~~ */
List<int> values = new List<int>();
List<int> runningTotal = new List<int>();
int val = 0;

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Please Input a Value: ({i+1}/5)");
    userInput = Console.ReadLine();

    if (int.TryParse(userInput, out val))
    {
        values.Add(val);
        if (i != 0) {
            runningTotal.Add((runningTotal[i-1] + val));
        }
        else
        {
            runningTotal.Add((val));
        }
    }
    else
    {
        Console.WriteLine("Invalid. Try Again.");
        i -= 1;
    }
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Value: {values[i]} | Running Total: {runningTotal[i]}");
}