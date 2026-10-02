namespace A22_Memory;

class Program
{
    static void sayingHello()
    {
        Console.WriteLine("Willkommen zum Spiel Memory! Falls du nicht weiss wie das Spiel funktioniert drücke \'y\'.");
        Console.WriteLine("Wenn du weisst wie Memory funktioniert, drücke irgend einen anderen Knopf.");
        string needsToExplain = Console.ReadLine();
        if (needsToExplain == "y")
        {
            Console.WriteLine("Unter jedem \'?\' befindet sich ein Symbol. Zu jedem Symbol gibt es 1 Symbolen Paar und dieses musst du finden.");
            Console.WriteLine("Dafür gibst du für beide Felder die Zeile und Spalte an.");
            Console.WriteLine("Beispiel: 1122 -> dieses würde das Feld in der Zeile 1 und Spalte 1 aufdeken und überprüfen ob im Feld auf der Zeile 2 und Spalte 2 das Symbol Paar ist.");
            Console.WriteLine("Viel Spass beim Spielen!!");
        }
        else
        {
            Console.WriteLine("Viel Spass beim Spielen!");
        }
    }

    static void gameState()
    {
        char[,] gameState = { { '#', '#' }, {'♥', '♥'} };
        for (int i = 0; i < gameState.GetLength(0); i++)
        {
            for (int j = 0; j < gameState.GetLength(1); j++)
            {
                Console.Write($"{gameState[i,j]}");
            }
            Console.WriteLine();
        }
        
    }

    static bool isTheSame(string fields)
    {
        bool sameSymbol = false;
        string zeile1 = fields.Substring(0, 1);
        string spalte1 = fields.Substring(1, 1);
        string zeile2 = fields.Substring(2, 1);
        string spalte = fields.Substring(3, 1);
        
        
        
        return sameSymbol;
    }

    static void drawMemory()
    {
        char[,] memory = { { '?', '?' }, { '?', '?' } };
        for (int i = 0; i < memory.GetLength(0); i++)
        {
            for (int j = 0; j < memory.GetLength(1); j++)
            {
                Console.Write($"{memory[i,j]}");
            }
            Console.WriteLine();
        }
    }


    static void Main(string[] args)
    {
        sayingHello();
        drawMemory();
        Console.Write("Beginne mit deinem ersten Zug: ");
        string fieldPicked = Console.ReadLine();
        isTheSame(fieldPicked);
    }
}