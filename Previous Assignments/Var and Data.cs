/* ~~~~~~~~~~~ Exercise 1: Swapping Variables ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 1: Swapping Variables ~~~~~~~~~~~ */");
int a = 4;
int b = 62;
int temp;

Console.WriteLine($"a: {a} b: {b}");

temp = a;
a = b;
b = temp;

Console.WriteLine($"a: {a} b: {b}");

Console.WriteLine("");
/* ~~~~~~~~~~~ Exercise 2: Personal Information Formatting ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 2: Personal Information Formatting ~~~~~~~~~~~ */");

string name = "Trenton";
int age = 17;
string hometown = "Tremtonton";

Console.WriteLine($"{name} is from {hometown}, and is {age} years old.");

Console.WriteLine("");
/* ~~~~~~~~~~~ Exercise 3: Temperature Conversion ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 3: Temperature Conversion ~~~~~~~~~~~ */");

double celsius;
double fahrenheit;

Console.WriteLine("Input a Celsius Tempurature Value");
string userValue = Console.ReadLine();

int userInt;
int.TryParse(userValue, out userInt);

celsius = (double)userInt;

fahrenheit = ((celsius * 9) / 5) + 32;

Console.WriteLine($"{celsius} degrees Celsius is equivalent to {fahrenheit} degrees Fahrenheit");

Console.WriteLine("");

/* ~~~~~~~~~~~ Exercise 4: Area of a Rectangle ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 4: Area of a Rectangle ~~~~~~~~~~~ */");

double width;
double height;

Console.WriteLine("Input a width for a rectangle:");
string userInput = Console.ReadLine();
int userRectInt;
int.TryParse(userInput, out userRectInt);
width = (double)userRectInt;

Console.WriteLine("Input a height for a rectangle:");
userInput = Console.ReadLine();
int.TryParse(userInput, out userRectInt);
height = (double)userRectInt;

double area = width * height;
double perimeter = (width * 2) + (height * 2);

Console.WriteLine($"The rectangle is width {width} and height {height}. Its perimeter is {perimeter} and its area is {area}.");

Console.WriteLine("");
/* ~~~~~~~~~~~ Exercise 5: Data Formatting ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 5: Data Formatting ~~~~~~~~~~~ */");

int integer = 123;
double doubling = 24;
char character = 'A';
bool boolean = false;
string text = "Lorem Ipsum";

Console.WriteLine($"{integer.GetType()}: {integer}");
Console.WriteLine($"{doubling.GetType()}: {doubling}");
Console.WriteLine($"{character.GetType()}: {character}");
Console.WriteLine($"{boolean.GetType()}: {boolean}");
Console.WriteLine($"{text.GetType()}: {text}");