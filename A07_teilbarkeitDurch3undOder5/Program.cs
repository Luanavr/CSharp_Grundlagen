namespace A07_teilbarkeitDurch3undOder5;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.Write($"{i},\t");
            }
        }
    }
}