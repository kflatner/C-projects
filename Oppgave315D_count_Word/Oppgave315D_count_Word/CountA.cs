namespace Oppgave315D_count_Word;

public class CountA
{
    public static int Count(string? text, char letter)
    {
        int count = 0;

        if (text != null)
            foreach (char c in text)
            {
                if (char.ToLower(c) == char.ToLower(letter))
                {
                    count++;
                }
            }

        return count;
    }  
}