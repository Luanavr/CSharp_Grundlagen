namespace A19_countVokale;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Schreibe etwas: ");
        string text = Console.ReadLine();
        string[] vokale = { "a", "e", "i", "o", "u", "ä", "ö", "ü" };
        int counterTotal = 0;
        int buchstabe1 = 0;
        int buchstabe2 = 0;
        int buchstabe3 = 0;
        int buchstabe4 = 0;
        int buchstabe5 = 0;
        int buchstabe6 = 0;
        int buchstabe7 = 0;
        int buchstabe8 = 0;

        for (int l = 0; l < text.Length; l++)
        {
            string textTeil = text.Substring(l, 1);
            if (textTeil.ToLower().Contains("a"))
            {
                buchstabe1++;
            }
            else if (textTeil.ToLower().Contains("e"))
            {
                buchstabe2++;
            }
            else if (textTeil.ToLower().Contains("i"))
            {
                buchstabe3++;
            }
            else if (textTeil.ToLower().Contains("o"))
            {
                buchstabe4++;
            }
            else if (textTeil.ToLower().Contains("u"))
            {
                buchstabe5++;
            }
            else if (textTeil.ToLower().Contains("ä"))
            {
                buchstabe6++;
            }
            else if (textTeil.ToLower().Contains("ö"))
            {
                buchstabe7++;
            }
            else if (textTeil.ToLower().Contains("ü"))
            {
                buchstabe8++;
            }
        }

        counterTotal = buchstabe1 + buchstabe2 + buchstabe3 + buchstabe4 + buchstabe5 + buchstabe6 + buchstabe7 +
                       buchstabe8;
        Console.Write($"Totale Vokale: {counterTotal}");
        Console.WriteLine();
        if (buchstabe1 > 0)             //"a", "e", "i", "o", "u", "ä", "ö", "ü" 
        {
            Console.WriteLine($"Im Text hat es {buchstabe1} mal ein A.");
        }
        if (buchstabe2 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe2} mal ein E.");
        }
        if (buchstabe3 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe3} mal ein I.");
        }
        if (buchstabe4 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe4} mal ein O.");
        }
        if (buchstabe5 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe5} mal ein U.");
        }
        if (buchstabe6 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe6} mal ein Ä.");
        }
        if (buchstabe7 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe7} mal ein Ö.");
        }
        if (buchstabe8 > 0)
        {
            Console.WriteLine($"Im Text hat es {buchstabe8} mal ein Ü.");
        }
    }
}