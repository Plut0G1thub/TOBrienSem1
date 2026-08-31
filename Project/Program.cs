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

