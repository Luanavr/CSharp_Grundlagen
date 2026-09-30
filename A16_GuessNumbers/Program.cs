namespace A16_GuessNumbers;

class Program
{
    static void Main(string[] args)
    {
        bool erraten = false;
        int tries = 0;
        Random randomNum = new Random();
        int random = randomNum.Next(1, 100);
        
        while (!erraten)
        {
            Console.Write("Rate eine Zahl: ");
            int guessedNum = int.Parse(Console.ReadLine());
            tries++;
    
            if (guessedNum != random)
            {
                if (guessedNum > random)
                {
                    Console.WriteLine($"Die gesuchte Zahl ist kleiner als {guessedNum}");
                }
                else if (guessedNum < random)
                {
                    Console.WriteLine($"Die gesuchte Zahl ist grösser als {guessedNum}");
                }
            }
            else
            {
                erraten = true;
                Console.WriteLine($"Super gemacht die Gesuchte Zahl war {random}!");
                Console.WriteLine($"Du hast {tries} Versuche gebraucht!");
                Console.WriteLine("Möchtest du noch ein mal spielen?: ");
                string again = Console.ReadLine();
                
                if (again.Contains("ja") || again.Contains("Ja") || again.Contains("JA") || again.Contains("jA"))
                {
                    erraten = false;
                    random = randomNum.Next(1, 100);
                    tries = 0;
                }
                else
                {
                    Console.WriteLine("Das Spiel wurde beendet.");
                }
            }
        }
        
    }
}