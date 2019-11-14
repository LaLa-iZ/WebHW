using System;

namespace film
{
    class MainPage
    {
        static void Main(string[] args)
        {
            string person = "noone";
            while (person != "finish")
            {
                Console.WriteLine("Who are you? Manager or Seacher? ");
                Console.WriteLine("If you are Manager enter M, if Seacher S and if you whant to finish, enter finish ");
                person = Console.ReadLine();

                switch (person)
                {
                    case "M":
                        Console.WriteLine("If you are ProducerManager, enter P {0}If you are CompanyManager, enter C {0}If you are GenreManager, enter G {0}If you are FilmManager, enter F {0}If you whant to return, enter return", Environment.NewLine);
                        break;
                    case "S":
                        Console.WriteLine("Seacher?");
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Try Again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
