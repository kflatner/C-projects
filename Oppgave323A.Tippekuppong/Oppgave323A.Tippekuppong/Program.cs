class Program
{
    static void Main()
    {
        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" +
                      " - halvgardering: HU, HB, UB\n" +
                      " - helgardering: HUB\n" +
                      "Hva har du tippet for denne kampen? ");
        var bet = Console.ReadLine();

        var match = new Match();

        while (match.MatchIsRunning)
        {
            Console.Write("Kommandoer: \n" +
                          " - H = scoring hjemmelag\n" +
                          " - B = scoring bortelag\n" +
                          " - X = kampen er ferdig\n" +
                          "Angi kommando: ");
            var command = Console.ReadLine();
            match.RegisterCommand(command);
            Console.WriteLine($"Stillingen er {match.GetScore()}.");
        }

        var isBetCorrect = match.IsBetCorrect(bet);
        var resultText = isBetCorrect ? "riktig" : "feil";
        Console.WriteLine($"Du tippet {resultText}");
    }
}