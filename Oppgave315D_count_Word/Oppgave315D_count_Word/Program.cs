
    using Oppgave315D_count_Word;

    Console.Write("Enter a sentence: ");
    var text = Console.ReadLine();

    Console.Write("Enter a letter to count: ");
    var input = Console.ReadLine();

    
    if (string.IsNullOrEmpty(input) || input.Length != 1)
    {
        Console.WriteLine("Please enter a single letter.");
        return;
    }

    char letter = input[0];

    int count = CountA.Count(text, letter);

    Console.WriteLine($"Number of '{letter}': {count}");


