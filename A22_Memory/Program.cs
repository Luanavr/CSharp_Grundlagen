namespace A22_Memory;

class Program
{

    static void gameState() //'☺', '#', '♦', '♠', '♥', '♣', '♫', '☼', '©', '☻', '▲', '►', '▼', '◄', '&', '§', '$', '£'.
    {
        char[,] gameState = { { '#', '#' }, {'♥', '♥'} };
        for (int i = 0; i < gameState.GetLength(0); i++)
        {
            for (int j = 0; j < gameState.GetLength(1); j++)
            {
                Console.Write($"[{i}][{j}] -> {gameState[i,j]}");
            }
            Console.WriteLine();
        }
    }

    static void drawMemory()
    {
        char[,] memory = { { '?', '?' }, { '?', '?' } };
        for (int i = 0; i < memory.GetLength(0); i++)
        {
            
        }
    }


    static void Main(string[] args)
    {
        
        char[,] memory;
        
        gameState();
        drawMemory();
    }
}