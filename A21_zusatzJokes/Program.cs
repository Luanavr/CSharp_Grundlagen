using System.Net;

namespace A21_zusatzJokes;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args) //JSONValue, JSONArray und JSONObject
    {
        string continueJokes = "";

        do
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            string jsonData = new StreamReader(responseStream).ReadToEnd();
            JArray array = JArray.Parse(jsonData);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[0]["text"]);
            }

            Console.Write($"Möchtest du noch einen Witz hören? (y/n)");
            continueJokes = Console.ReadLine();
        } while (continueJokes == "y");
    }
}