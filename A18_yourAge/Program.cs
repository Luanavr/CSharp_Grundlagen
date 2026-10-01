using System.Runtime.InteropServices.JavaScript;

namespace A18_yourAge;

class Program
{

    static void Main(string[] args)
    {
        int ageInYears;
        int ageInMonths;
        int ageInWeeks;
        int ageInDays;
        
        DateTime today = DateTime.Today; 
        Console.WriteLine(today);
        
        Console.WriteLine("Gibt dein Geburtstag ein (xx.xx.xxxx):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        DateTime birthdayThisYear = new DateTime(
            today.Year, birthday.Month, birthday.Day
        );
        
        TimeSpan intervalDays = today - birthday;
        ageInDays = intervalDays.Days;
        
        ageInMonths = ageInDays / 12;
        
        ageInWeeks = ageInDays / 7;
        
        ageInYears = today.Year - birthday.Year;
            if (birthdayThisYear>today)
            {
                ageInYears--;
            }
            if (birthdayThisYear < today)
            {
                
            }
        Console.WriteLine($"Tage: {ageInDays} Wochen: {ageInWeeks} Monate: {ageInMonths} Jahre: {ageInYears}");
        
    }
}