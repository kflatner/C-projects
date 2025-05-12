using Oppgave315A_Random_tall;


var name = MyConsole.Ask(question: "Hva heter du?");
Console.WriteLine($"Hei, {name}!");

var guessCounter = 1;

var doYou = MyConsole.AskForBool("wanna guess the number?");
if (doYou)
{
    Console.WriteLine($"Cool!, start guessing!");
}
else 
{
    Console.WriteLine($"Oh well, maybe another time then {name}!");
    return;
}

var targetNumber = MyConsole.RandomGenerator.GetRandomNumber(1, 100);
int guessedNumber = -1;

while (guessedNumber != targetNumber)
{
    guessedNumber = MyConsole.AskForInt(question: $"What's your guess? this is the {guessCounter} try!");
    guessCounter++;

    if (guessedNumber == targetNumber)
    {
        Console.WriteLine("Correct!");
    }
    else if (guessedNumber > targetNumber)
    {
        Console.WriteLine("Incorrect! Try smaller numbers!");
    }
    else 
    {
        Console.WriteLine("Incorrect! Try bigger numbers!");
    }
}






