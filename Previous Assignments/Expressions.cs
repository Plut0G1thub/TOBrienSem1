/* ~~~~~~~~~~~ Exercise 1: Statements vs Expressions ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 1: Statements vs Expressions ~~~~~~~~~~~ */");

int calculation = 34 * 17 - 12 / 6;
calculation -= (9 * 3);
Console.WriteLine(calculation + " | calculation -= (9 * 3);");

Console.WriteLine("");

/* ~~~~~~~~~~~ Exercise 2: Expression Placement and Usage ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 2: Expression Placement and Usage ~~~~~~~~~~~ */");

// Expression 1: (4 * (7 - 9) + 11) / 3
Console.WriteLine("Expression 1: (4 * (7 - 9) + 11) / 3");

string result = Convert.ToString((4 * (7 - 9) + 11) / 3);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

// Expression 2: (3 == 2 && 4 > 1) || false
Console.WriteLine("Expression 2: (3 == 2 && 4 > 1) || false");

result = Convert.ToString((3 == 2 && 4 > 1) || false);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

//Expression 3: (32.1 - 3.445) * 17.7 / (2.38 + 21.9)
Console.WriteLine("Expression 3: (32.1 - 3.445) * 17.7 / (2.38 + 21.9)");

result = Convert.ToString((32.1 - 3.445) * 17.7 / (2.38 + 21.9));
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

/* ~~~~~~~~~~~ Exercise 3: Order of Operations ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 3: Order of Operations ~~~~~~~~~~~ */");

// Expression 1: (4 * (7 - 9) + 11) / 3
Console.WriteLine("Expression 1: 4 * 7 - 9 + 11 / 3");

result = Convert.ToString(4 * (7 - 9) + 11 / 3);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

// Expression 2: (3 == 2 && 4 > 1) || false
Console.WriteLine("Expression 2: 3 == 2 && 4 > 1 || false");

result = Convert.ToString(3 == 2 && 4 > 1 || false);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

//Expression 3: (32.1 - 3.445) * 17.7 / (2.38 + 21.9)
Console.WriteLine("Expression 3: 32.1 - 3.445 * 17.7 / 2.38 + 21.9");

result = Convert.ToString(32.1 - 3.445 * 17.7 / 2.38 + 21.9);
Console.WriteLine($"Result: {result}");

Console.WriteLine("");

/* ~~~~~~~~~~~ Exercise 4: Type-Inferred Variables ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 4: Type-Inferred Variables ~~~~~~~~~~~ */");

int declared = 28;
var inferred = declared * 2.13;
bool isDeclared = true;
var isInferred = 2 > 3;
var alsoInferred = $"{inferred}";
Console.WriteLine(declared.GetType());
Console.WriteLine(inferred.GetType());
Console.WriteLine(isDeclared.GetType());
Console.WriteLine(isInferred.GetType());
Console.WriteLine(alsoInferred.GetType());

/* ~~~~~~~~~~~ Exercise 5: Expressions in Strings ~~~~~~~~~~~ */
Console.WriteLine("/* ~~~~~~~~~~~ Exercise 5: Expressions in Strings ~~~~~~~~~~~ */");

// Expression 1
int resultInt;
resultInt = (19*12) + 7 - 321;
Console.WriteLine($"The Expression '(19*12) + 7 - 321' equivilates to {resultInt}, which is a {resultInt.GetType()}");

Console.WriteLine();

// Expression 2
bool resultBool;
resultBool = (83+9) *2 >= 45;

Console.WriteLine($"The Expression '(83+9) *2 >= 45' equivilates to {resultBool}, which is a {resultBool.GetType()}");

Console.WriteLine();

// Expression 3
double resultDoub;
resultDoub = (double)(15 + 19*(34 + 12));

Console.WriteLine($"The Expression '(83+9) *2 >= 45' equivilates to {resultDoub}, which is a {resultDoub.GetType()}");

Console.WriteLine();

//Expression 4
string resultString;

resultString = "(123/12312/4520) * 0";

Console.WriteLine($"The Expression '(123/12312/4520) * 0' equivilates to {resultString}, which is a {resultString.GetType()}");

Console.WriteLine();