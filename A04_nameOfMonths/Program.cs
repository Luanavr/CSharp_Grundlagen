namespace A04_nameOfMonths;

class Program
{
    static void Main(string[] args)
    {
        string [] months = {"January", "February", "March", "April", "May","June","July", "August", "September", "October", "November", "December"};
        Console.Write("Gib eine Zahl zwischen 1 und 12 ein. Ich gebe dir den entsprechenden Monat aus.");
        string validateNum = Console.ReadLine();
        int zahl;
        if (int.TryParse(validateNum, out zahl)==true && zahl<=12)
        {
            Console.WriteLine($"Der {validateNum}. Monat ist der {months[zahl-1]}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe");
        }
    }
}