/* ~~~~~~~~~~~ Exercise 1: Positive, Negative, or Zero ~~~~~~~~~~~ */
Console.WriteLine("Give a number, positive, negative, or zero."); 
var userInput = Console.ReadLine();
int number;

int.TryParse(userInput, out number);

if (number == 0)
{
    Console.WriteLine($"The Number {number} is zero.");
} 
else if (number >0)
{
    Console.WriteLine($"The number {number} is positive.");
}
else if (number <0)
{
    Console.WriteLine($"The number {number} is negative.");
}

/* ~~~~~~~~~~~ Exercise 2: Number Comparison ~~~~~~~~~~~ */
Console.WriteLine();
int number1;
int number2;

Console.WriteLine("Give a number:");
userInput = Console.ReadLine();

int.TryParse(userInput, out number1);

Console.WriteLine("Give a number:");
userInput = Console.ReadLine();

int.TryParse(userInput, out number2);

if (number1 == number2)
{
    Console.WriteLine($"The numbers {number1} and {number2} are equal.");
}
else if (number1 > number2){
    Console.WriteLine($"The number {number1} is greater then the number {number2}.");
}
else if (number1 < number2)
{
    Console.WriteLine($"The number {number1} is less than the number {number2}.");
}

/* ~~~~~~~~~~~ Exercise 3: Letter Grade Calculator ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Please enter a number 0-100, representing a grade.");
userInput = Console.ReadLine();
int grade;

int.TryParse(userInput, out grade);

if (grade <=59)
{
    Console.WriteLine($"A score of {grade} represents the letter grade of F.");
}
else if (grade <=69 && grade > 59)
{
    Console.WriteLine($"A score of {grade} represents the letter grade of D.");
}
else if (grade <=79 && grade > 69)
{
    Console.WriteLine($"A score of {grade} represents the letter grade of C.");
}
else if (grade <=89 && grade > 79)
{
    Console.WriteLine($"A score of {grade} represents the letter grade of B.");
}
else if (grade <=100 && grade > 89)
{
    Console.WriteLine($"A score of {grade} represents the letter grade of A.");
}

/* ~~~~~~~~~~~ Exercise 4: Day of the Week ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Enter a number 1-7");
userInput = Console.ReadLine();
int day;
string dayOfWeek = "default";
int.TryParse(userInput, out day);

switch (day)
{
    case 1:
        dayOfWeek = "Monday";
        break;
    case 2:
        dayOfWeek = "Tuesday";
        break;
    case 3:
        dayOfWeek = "Wednesday";
        break;
    case 4:
        dayOfWeek = "Thursday";
        break;
    case 5:
        dayOfWeek = "Friday";
        break;
    case 6:
        dayOfWeek = "Saturday";
        break;
    case 7:
        dayOfWeek = "Sunday";
        break;
}

Console.WriteLine($"Today is {dayOfWeek}.");

/* ~~~~~~~~~~~ Exercise 5: Discount Calculation ~~~~~~~~~~~ */
Console.WriteLine();

Console.WriteLine("Enter the price of purchase:");
userInput = Console.ReadLine();
int purchase;
int finalPurchase;

int.TryParse(userInput, out purchase);

if (purchase >= 100)
{
    finalPurchase = purchase - (int)(purchase * 0.1);
}
else
{
    finalPurchase = purchase;
}
Console.WriteLine($"Final Purchase Cost: ${finalPurchase}");