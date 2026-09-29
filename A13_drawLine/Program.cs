namespace A13_drawLine;

class Program
{
    static void drawLine(int zahl)
    {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl; j++)
                {
                    if (i != j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
    }

    static void Main(string[] args)
    {
        Console.Write("Gib eine Zahl ein: ");
        int zahl = int.Parse(Console.ReadLine());
        drawLine(zahl);
    }
}