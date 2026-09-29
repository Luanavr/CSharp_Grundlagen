namespace A05_Flussdiagramm_02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wie viele Kilometer möchtest du Rennen?");
        int kilometer = Convert.ToInt32(Console.ReadLine());
        if (kilometer > 42)
        {
            Console.WriteLine("Du schaffst das nicht");
        }
        else
        {
            double rounds = kilometer / 0.4;
            Console.WriteLine($"Das sind insgesamt {rounds} Runden die du laufen musst.");
            Console.Write("Bereit?");
            string ready = Console.ReadLine();
            if (ready == "Ja" || ready == "ja")
            {
                for (int i = 0; i <= rounds; i++)
                {
                    Console.WriteLine($"Du bist bei Runde {i}");
                }
                Console.WriteLine("Geschafft!");
            }

        }
    }
}