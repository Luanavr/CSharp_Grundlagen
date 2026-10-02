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
            Console.WriteLine(
                "Unter jedem \'?\' befindet sich ein Symbol. Zu jedem Symbol gibt es 1 Symbolen Paar und dieses musst du finden.");
            Console.WriteLine("Dafür gibst du für beide Felder die Zeile und Spalte an.");
            Console.WriteLine(
                "Beispiel: 1122 -> dieses würde das Feld in der Zeile 1 und Spalte 1 aufdeken und überprüfen ob im Feld auf der Zeile 2 und Spalte 2 das Symbol Paar ist.");
            Console.WriteLine("Viel Spass beim Spielen!!");
        }
        else
        {
            Console.WriteLine("Viel Spass beim Spielen!");
        }
    }

    static void drawMemory(char[,] memory)
    {
        Console.Write(" ");
        Console.Write(" ");
        for (int i = 1; i <= memory.GetLength(1); i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }

        Console.WriteLine(" ");
        for (int i = 0; i < memory.GetLength(0); i++)
        {
            Console.Write(i + 1);
            Console.Write(" ");
            for (int j = 0; j < memory.GetLength(1); j++)
            {
                Console.Write($"{memory[i, j]}");
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    static void shuffleMemory(char[,] array)
    {
        Random random = new Random();
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int totalElements = rows * cols;

        char[] array1d = new char [totalElements];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array1d[index] = array[i, j];
                index++;
            }
        }

        while (totalElements > 1)
        {
            totalElements--;
            int randomPlace = random.Next(totalElements + 1);
            char temp = array1d[randomPlace];
            array1d[randomPlace] = array1d[totalElements];
            array1d[totalElements] = temp;
        }

        index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = array1d[index];
                index++;
            }
        }
    }

    static bool isItTheSame(char[,] array, string fieledPicked)
    {
        bool itIsTheSame;

        int row1 = int.Parse(fieledPicked.Substring(0, 1)) - 1;
        int columns1 = int.Parse(fieledPicked.Substring(1, 1)) - 1;
        int row2 = int.Parse(fieledPicked.Substring(2, 1)) - 1;
        int columns2 = int.Parse(fieledPicked.Substring(3, 1)) - 1;

        if (array[row1, columns1] == array[row2, columns2])
        {
            itIsTheSame = true;
        }
        else
        {
            itIsTheSame = false;
        }

        return itIsTheSame;
    }

    static void currentState(string fieledPicked, char[,] arrayMemory, char[,] arrayQuestionsmarks)
    {
        int row1 = int.Parse(fieledPicked.Substring(0, 1)) - 1;
        int columns1 = int.Parse(fieledPicked.Substring(1, 1)) - 1;
        int row2 = int.Parse(fieledPicked.Substring(2, 1)) - 1;
        int columns2 = int.Parse(fieledPicked.Substring(3, 1)) - 1;

        arrayQuestionsmarks[row1, columns1] = arrayMemory[row1, columns1];
        arrayQuestionsmarks[row2, columns2] = arrayMemory[row2, columns2];

        drawMemory(arrayQuestionsmarks);
    }

    static void isNotTheSame(string fieledPicked, char[,] arrayMemory, char[,] arrayQuestionsmarks)
    {
        int row1 = int.Parse(fieledPicked.Substring(0, 1)) - 1;
        int columns1 = int.Parse(fieledPicked.Substring(1, 1)) - 1;
        int row2 = int.Parse(fieledPicked.Substring(2, 1)) - 1;
        int columns2 = int.Parse(fieledPicked.Substring(3, 1)) - 1;

        arrayQuestionsmarks[row1, columns1] = '?';
        arrayQuestionsmarks[row2, columns2] = '?';
    }

    static void isTheSameConfirmed(string fieledPicked, char[,] arrayMemory, char[,] arrayQuestionsmarks)
    {
        int row1 = int.Parse(fieledPicked.Substring(0, 1)) - 1;
        int columns1 = int.Parse(fieledPicked.Substring(1, 1)) - 1;
        int row2 = int.Parse(fieledPicked.Substring(2, 1)) - 1;
        int columns2 = int.Parse(fieledPicked.Substring(3, 1)) - 1;

        arrayQuestionsmarks[row1, columns1] = ' ';
        arrayQuestionsmarks[row2, columns2] = ' ';
    }

    static void Main(string[] args)
    {
        char[,] memory = { { '#', '#', '♫', '♫' }, { '♥', '♥', '©', '©' }, { '♦', '♦', '☺', '☺' } };
        char[,] memoryRightNow = { { '?', '?', '?', '?' }, { '?', '?', '?', '?' }, { '?', '?', '?', '?' } };

        bool gameFinished = false;

        sayingHello();
        shuffleMemory(memory);
        drawMemory(memoryRightNow);

        do
        {
            for (int i = 0; i < memoryRightNow.GetLength(0); i++)
            {
                for (int j = 0; j < memoryRightNow.GetLength(1); j++)
                {
                    if (memoryRightNow[i, j] == '?')
                    {
                        gameFinished = false;
                    }
                    else
                    {
                        gameFinished = true;
                    }
                }
            }

            if (gameFinished == false)
            {
                Console.Write("Mache deinen ersten Zug: ");
                string fieldPick = Console.ReadLine();
                Console.Clear();
                
                currentState(fieldPick, memory, memoryRightNow);
                if (isItTheSame(memory, fieldPick))
                {
                    Console.WriteLine("Wow super gemacht! Du hast ein Paar gefunden");
                    isTheSameConfirmed(fieldPick, memory, memoryRightNow);
                }
                else
                {
                    isNotTheSame(fieldPick, memory, memoryRightNow);
                    Console.Write("Leider nicht aber weiter so!");
                }
            }
        } while (!gameFinished);
        Console.WriteLine("Wow super gemacht du hast das Memory gelöst!");
    }
}