Random rand = new Random();
int randomNumber = rand.Next(20) + 1;

var userInput = "";
var userNum = 0;
var attempts = 0;

while (userNum != randomNumber)
{
    Console.WriteLine("Guess My Number!");
    userInput = Console.ReadLine();

    if (int.TryParse(userInput, out userNum))
    {
        if (userNum > randomNumber)
        {
            Console.WriteLine("Too high! Guess lower.");
        }
        else if (userNum < randomNumber)
        {
            Console.WriteLine("Too low! Guess higher.");
        }
        attempts += 1;
    }
    else
    {
        Console.WriteLine("Invalid!");
    }
}

Console.WriteLine($"You got my number in {attempts} attempts!");