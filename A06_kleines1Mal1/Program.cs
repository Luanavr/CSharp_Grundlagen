namespace A06_kleines1Mal1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Das kleine 1 x 1");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}