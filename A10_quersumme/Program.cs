namespace A10_quersumme;

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
    static void Main(string[] args)
    {
        Console.Write("Zahl: ");
        int zahl = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Die Quersumme von {zahl} ist {BerechneQuersumme(zahl)}");
    }
}