namespace A17_SortArray;

class Program
{
    private static void SortiereArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int p = 0; p < arr.Length - i - 1; p++)
            {
                if (arr[p] > arr[p + 1])
                {
                    int temp = arr[p];
                    arr[p] = arr[p + 1];
                    arr[p + 1] = temp;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"[{i}] -> {arr[i]} ");
        }
    }

    static void Main(string[] args)
    {
        string eingabe = Console.ReadLine();
        string[] eingabeArray = eingabe.Split(' ');
        string[] forbidden =
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z"
        };
        int somethingForbidden = 0;
        bool nothingForbidden = true;
        string[] isForbidden = { };

        for (int i = 0; i < eingabeArray.Length; i++)
        {
            for (int p = 0; p < forbidden.Length; p++)
            {
                if (eingabeArray[i].ToLower().Contains(forbidden[p]))
                {
                    somethingForbidden++;
                    nothingForbidden = false;
                }
            }
        }

        while (somethingForbidden == 0)
        {
            int[] numbers = new int[eingabeArray.Length];
            for (int i = 0; i < eingabeArray.Length; i++)
            {
                numbers[i] = Convert.ToInt32(eingabeArray[i]);
            }

            SortiereArray(numbers);
            somethingForbidden = 1;
        }

        if (nothingForbidden == false)
        {
            Console.WriteLine("Du hast einen Buchstaben eingegeben. Bitte gib gültige Zahlen ein!");
        }
    }
}