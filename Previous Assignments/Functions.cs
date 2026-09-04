/* ~~~~~~~~~~~ Exercise 1: Check Even or Odd ~~~~~~~~~~~ */
bool IsEven(int number) 
{ 
    return number % 2 == 0; 
}

switch (IsEven(15))
{
    case true :
        Console.WriteLine("Is Even");
        break;
    case false:
        Console.WriteLine("Is Odd");
        break;
}

/* ~~~~~~~~~~~ Exercise 2: Array Functions ~~~~~~~~~~~ */

int SumArray(int[] numbers) {
    int sum = 0;
    foreach (int num in numbers) {
        sum += num;
    }
    return sum;
}

double AverageArray(int[] numbers)
{
    int summedArray = SumArray(numbers);
    double averageArray = summedArray / numbers.Length;
    
    return averageArray;
}

int[] array = new int[5]{1,2,3,4,5};

Console.WriteLine($"The sum of the array {array} is {SumArray(array)}");
Console.WriteLine($"Average of the array {array} is {AverageArray(array)}");

/* ~~~~~~~~~~~ Exercise 3: Prompt for Integer ~~~~~~~~~~~ */

int PromptInt(string message)
{
    Console.WriteLine(message);
    string response = Console.ReadLine();
    int returnVal = 0;
    
    while (!int.TryParse(response, out returnVal))
    {
        Console.WriteLine(message);
        response = Console.ReadLine();
        returnVal = 0;
    }
    return returnVal;
}

Console.WriteLine($"This is your integer: {PromptInt("Enter an Integer")}");
/* ~~~~~~~~~~~ Exercise 4: Factorial ~~~~~~~~~~~ */

int Factorial(int n)
{
    if (n<0)
    {
        Console.WriteLine("Factorial: Number Must Be Positive.;");
        return 0;
    }
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    
    return result;

}

Console.WriteLine(Factorial(12));