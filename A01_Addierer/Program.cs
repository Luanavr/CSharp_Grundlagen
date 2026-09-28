namespace AufgabenVariable;

class Program
{
    static void Main(string[] args)
    {
        static int calcSumme(int zahl1, int zahl2){
        int summe = zahl1 + zahl2;
        return summe;
        }
        Console.Write("Gibt eine Zahl ein:");
        int zahl1 = int.Parse(Console.ReadLine());
        Console.Write("Gib eine zweitelll Zahl ein:");
        int zahl2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Die Summe deiner 2 Zahlen ist {calcSumme(zahl1, zahl1)}");
    }
}