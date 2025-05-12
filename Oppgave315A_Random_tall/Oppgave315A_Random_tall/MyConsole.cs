namespace Oppgave315A_Random_tall;

public class MyConsole
{
    public static string Ask(string question)
    {
        Console.Write(question + " ");
        return Console.ReadLine();
    }

    public static int AskForInt(string question)
    {
        var answerStr = Ask(question);
        return Convert.ToInt32(answerStr);
    }
      
    public static bool AskForBool(string question)
    {
        var answerStr =Ask(question + "(j/n)");
       
        if (answerStr.StartsWith("j"))
            return true;
        if (answerStr.StartsWith("n"))
            return false;
        return AskForBool(question);

    }
    public static class RandomGenerator
    {
        private static readonly Random Random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            return Random.Next(min, max);
        }
    }

  
   
}
