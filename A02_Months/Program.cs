namespace A02_Months;

class Program
{
    static void Main(string[] args)
    {
        static int calcSeconds(int zahl1)
        {
            int seconds = zahl1 * 86400;
            return seconds;
        }
        Console.Write("Monat mit wie vielen Tagen?:");
        string days = Console.ReadLine();

        int zahl;
        if (int.TryParse(days, out zahl) == true)
        {
            int daysInInt = int.Parse(days);
            switch (daysInInt)
            {
                case >31:
                case <28:
                    Console.WriteLine($"Ungültige Eingabe: Es gibt keinen Monat mit {daysInInt} Tage");
                    break;
                default: 
                    Console.WriteLine($"Ein Monat mit {daysInInt} Tagen hat {calcSeconds(daysInInt)} Sekunden");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ihre Eingabe ist ungültig!");
        }
    }
}