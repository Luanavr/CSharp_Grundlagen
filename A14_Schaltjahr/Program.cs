namespace A14_Schaltjahr;

class Program
{
    static void Main(string[] args)
    {
        bool programm = true;
        Console.WriteLine("Dieses Programm testet ob ein Jahr ein Schaltjahr ist oder nicht.");
        while (programm)
        {
            Console.Write("Eingabe Jahr: (q to quit)");
            string input = Console.ReadLine();
            if (input.Contains("q"))
            {
                Console.WriteLine("Du hast das Spiel beendet.");
                programm = false;
            }
            else
            {
                int year = int.Parse(input);
                if (year % 4 == 0 && year % 100 !=0)
                {
                    Console.WriteLine($"Das Jahr {year} ist ein Schaltjahr.");
                }
                else if (year % 400 ==0)
                {
                    Console.WriteLine($"Das Jahr {year} ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"Das Jahr {year} ist KEIN Schaltjahr.");
                }
            }
        }
    }
}