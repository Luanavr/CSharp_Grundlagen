namespace A11_quersummeTeilbar;

class Program
{
    static int BerechneQuersumme(int zahl)
    {
        int sum = 0;
        while  (zahl !=0)
        {
            sum = sum + (zahl % 10);
            zahl = zahl / 10;
        }
        return sum;
    }

    static int quersummeDurchZahl(int zahl)
    {
        int result = 0;
        int quersumme = BerechneQuersumme(zahl);
        if (zahl % quersumme == 0)
        {
            result = zahl / quersumme;
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Git eine erste Zahl ein:");
        int zahl1 = int.Parse(Console.ReadLine());
        Console.Write("Git eine zweite Zahl ein:");
        int zahl2 = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------------");
        Console.Write($"Zahl:\t");
        Console.Write($"Quersumme:\t");
        Console.WriteLine($"Zahl / Quersumme:\t");
        Console.WriteLine("--------------------------------------");
        for (int i = zahl1; i <= zahl2; i++)
        {
            if (quersummeDurchZahl(i) != 0)
            {
                
                Console.Write($"{i}\t");
                Console.Write($" {BerechneQuersumme(i)}\t\t");
                Console.Write($" {quersummeDurchZahl(i)}\t");
                Console.WriteLine("");
            }
        }
    }
}