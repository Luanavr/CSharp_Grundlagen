using System.Xml;

namespace A08_verboteneWörter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dein Kommentar:");
        string comment = Console.ReadLine();
        int badWordCounter = 0;
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch", "scheisse" };
        for(int i = 0; i < forbiddenWords.Length; i++)
        {
            if (comment.Contains(forbiddenWords[i]))
            {
                badWordCounter++;
            }
        }

        if (badWordCounter > 0)
        {
            Console.WriteLine($"Du hast {badWordCounter} verbotene Wörter");
        }
        else
        {
            Console.WriteLine($"Danke für den Kommentar");
        }
    }
}