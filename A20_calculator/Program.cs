namespace A20_calculator;

class Program
{
    static double add2Num(double zahl1, double zahl2)
    {
        double resultat = zahl1 + zahl2;
        return resultat;
    }

    static double sub2Num(double zahl1, double zahl2)
    {
        double resultat = zahl1 - zahl2;
        return resultat;
    }

    static double mult2Num(double zahl1, double zahl2)
    {
        double result = zahl1 * zahl2;
        return result;
    }

    static double div2Num(double zahl1, double zahl2)
    {
        double result = zahl1 / zahl2;
        return result;
    }


    static void Main(string[] args)
    {
        bool add = false;
        bool sub = false;
        bool mult = false;
        bool div = false;

        bool firstFound = false;
        bool noNumbersLeft1 = false;
        bool secondFound = false;
        bool symbolFound = false;
        

        string[] forbidden =
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z"
        };
        
        string zahl1 = "";
        double zahl1AsDouble = 0;
        string zahl2 = "";
        double zahl2AsDouble = 0;

        int stopped = 0;

        string rechnung = "";

        while (rechnung != "q" )
        {
           
            Console.WriteLine("Mache eine Rechnung (q to quit): ");
            rechnung = Console.ReadLine();
            for (int i = 0; i < rechnung.Length; i++)
            {
                string rechnungSmall = rechnung.Substring(i, 1);
                if (rechnungSmall == "q")
                {
                    Console.WriteLine("Du hast das Programm beendet.");
                    break;
                }
                
            }
            
            while (!noNumbersLeft1)
            {
                for (int i = 0; i < rechnung.Length; i++)
                {
                    string rechnungSmall = rechnung.Substring(i, 1);

                    if (rechnungSmall.Contains("0") || rechnungSmall.Contains("1") || rechnungSmall.Contains("2")
                        || rechnungSmall.Contains("3") || rechnungSmall.Contains("4") || rechnungSmall.Contains("5")
                        || rechnungSmall.Contains("6") || rechnungSmall.Contains("7") || rechnungSmall.Contains("8")
                        || rechnungSmall.Contains("9"))
                    {
                        zahl1 = zahl1 + rechnungSmall;
                        stopped = i;
                        firstFound = true;
                    }
                    else if (firstFound)
                    {
                        noNumbersLeft1 = true;
                        break;
                    }
                }

                if (noNumbersLeft1)
                {
                    break;
                }
            }

            zahl1AsDouble = double.Parse(zahl1);


            for (int i = 0; i < rechnung.Length; i++)
            {
                string rechnungSmall = rechnung.Substring(i, 1);
                if (rechnungSmall.Contains("+"))
                {
                    add = true;
                    stopped = i;
                }
                else if (rechnungSmall.Contains("-"))
                {
                    sub = true;
                    stopped = i;
                }
                else if (rechnungSmall.Contains("*"))
                {
                    mult = true;
                    stopped = i;
                }
                else if (rechnungSmall.Contains("/"))
                {
                    div = true;
                    stopped = i;
                }
            }


            for (int i = stopped; i < rechnung.Length; i++)
            {
                string rechnungSmall = rechnung.Substring(i, 1);

                if (rechnungSmall.Contains("0") || rechnungSmall.Contains("1") || rechnungSmall.Contains("2")
                    || rechnungSmall.Contains("3") || rechnungSmall.Contains("4") || rechnungSmall.Contains("5")
                    || rechnungSmall.Contains("6") || rechnungSmall.Contains("7") || rechnungSmall.Contains("8")
                    || rechnungSmall.Contains("9"))
                {
                    zahl2 = zahl2 + rechnungSmall;
                    secondFound = true;
                }
                else if (secondFound)
                {
                    break;
                }
            }


            zahl2AsDouble = double.Parse(zahl2);

            if (add)
            {
                Console.WriteLine($"{zahl1AsDouble} + {zahl2AsDouble} = {add2Num(zahl1AsDouble, zahl2AsDouble)} ");
            }
            else if (sub)
            {
                Console.WriteLine($"{zahl1AsDouble} - {zahl2AsDouble} = {sub2Num(zahl1AsDouble, zahl2AsDouble)} ");
            }
            else if (mult)
            {
                Console.WriteLine($"{zahl1AsDouble} * {zahl2AsDouble} = {mult2Num(zahl1AsDouble, zahl2AsDouble)} ");
            }
            else if (div)
            {
                if (zahl2AsDouble != 0)
                {

                    Console.WriteLine($"{zahl1AsDouble} / {zahl2AsDouble} = {div2Num(zahl1AsDouble, zahl2AsDouble)} ");
                }
                else
                {
                    Console.WriteLine("Du kannst nicht durch 0 dividieren.");
                }
        }

        zahl1 = "";
        zahl1AsDouble = 0;
        zahl2 = "";
        zahl2AsDouble = 0;

        stopped = 0;

        rechnung = "";

        add = false;
        sub = false;
        mult = false;
        div = false;

        firstFound = false;
        noNumbersLeft1 = false;
        secondFound = false;
        symbolFound = false;
    }
}

}