namespace A12_Aufsummieren;

class Program
{
    static int[] SumUp(int[] arr) 
    {    
        //Rückgabe-Array initialisieren 
        int[] result = new int[arr.Length];
        result[0] = arr[0];
        for (int i = 0; i <arr.Length-1; i++)
        {
        result[i+1] = result[i] + arr[i+1];
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gib eine beliebige Anzahl Zahlen ein und trenne sie mit einem Komma. (,)");
        string eingabe = Console.ReadLine();
        string[] arrayString  = eingabe.Split(',');
        int[] intArray = Array.ConvertAll(arrayString, int.Parse);
        for (int i = 0; i < SumUp(intArray).Length; i++)
        {
            Console.Write($"[{i}] -> {SumUp(intArray)[i]}, ");
        }
    }
}























