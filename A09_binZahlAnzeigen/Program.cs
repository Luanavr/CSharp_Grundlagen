namespace A09_binZahlAnzeigen;

class Program
{
    static void Main(string[] args)
    {
        bool weitermachen = true;
        string bin = "";
        int newValue;
        while (weitermachen)
        {
            Console.Write("Bitte geben Sie einen Zahl ein: ");
            string zahl = Console.ReadLine();
            if (int.TryParse(zahl, out int zahl2) == true)
            {
                int zahlInt = int.Parse(zahl);
                weitermachen = true;
                do
                {
                    int rest = zahlInt % 2;
                    bin = rest + bin;
                    newValue = zahlInt / 2;
                    zahlInt = newValue;
                } 
                while (zahlInt != 0);

                Console.WriteLine(bin);
                bin = "";
            }
            else
            {
                weitermachen = false;
            }
        }
    }
}