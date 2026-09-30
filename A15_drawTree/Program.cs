namespace A15_drawTree;

class Program
{
    static void drawLine()
    {
        Console.Write("*");
    }

    static void drawNothing()
    {
        Console.Write(" ");
    }
    
    static void Main(string[] args)
    {
        
        Console.Write("Gibt die Breite des Stammes ein (muss ungerade sein!): ");
        int stammWidth = int.Parse(Console.ReadLine());
        Console.Write("Gibt die Höhe des Stammes ein: ");
        int stammHeight = int.Parse(Console.ReadLine());
        Console.Write("Gibt die Höhe der Krone ein: ");
        int crownHeight = int.Parse(Console.ReadLine());

        int maxBottom = 1+(2*(crownHeight-1));
        int space = (maxBottom - 1) / 2;
        int crown = 0;
        int spaceForLog = crownHeight-1;

        if (stammWidth > 1)
        {
            for (int i = 0; i < (stammWidth-1)/2; i++)
            {
                spaceForLog--;
            }
        }
            
        for (crown = 0; crown <= crownHeight;crown++)
        {
            if (crown == stammWidth)
            {
                
            }
            for (int p = space; p >= 0; p--)
            {
                drawNothing();
                

            }

            for (int p = 0; p <maxBottom - (2 * space); p++)
            {
                drawLine();
            }

            space = space - 1;
            Console.WriteLine();
            
        }
         
        for (int i = 0; i < stammHeight; i++)
        {
            
            for (int p = 0; p <= spaceForLog; p++)
            {
                drawNothing();
            }
            for (int p = 0; p < stammWidth; p++)
            {
                drawLine();
            }
            Console.WriteLine();
        }


    }
}