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
                        string manager = "noone";
                        while (manager != "return")
                        {
                            Console.WriteLine("If you are ProducerManager, enter P {0}If you are CompanyManager, enter C {0}If you are GenreManager, enter G {0}If you are FilmManager, enter F {0}If you whant to return, enter return", Environment.NewLine);
                            manager = Console.ReadLine();

                            string method = "nomethod";

                            switch (manager)
                            {
                                case "P":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Producer, enter A{0}If you would like to Change Producer, enter C{0}If you would like to Delete Producer, enter D{0}If you would like to Get All Producers, enter GetAll{0}If you would like to Get Producer By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                        string id;
                                        switch (method)
                                        {
                                            case "A":
                                                Console.WriteLine("Write Producer id: ");
                                                id = Console.ReadLine();
                                                Console.WriteLine("Write Producer's name: ");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Write Producer's surname: ");
                                                string surname = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    ProducerManager.Add(i, name, surname);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "C":
                                                Console.WriteLine("If you whant to change id, enter id{0}If you whant to change name, enter name{0}If you whant to change surname, enter surname{0}", Environment.NewLine);
                                                string change = Console.ReadLine();
                                                switch (change)
                                                {
                                                    case "id":
                                                        Console.Write("Write Producer's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Producer's id: ");
                                                        string newid = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            int newi = Convert.ToInt32(newid);
                                                            ProducerManager.Change(i, newi);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    case "name":
                                                        Console.Write("Write Producer's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Producer's name: ");
                                                        string newname = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            ProducerManager.ChangeName(i, newname);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    case "surname":
                                                        Console.Write("Write Producer's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Producer's surname: ");
                                                        string newsurname = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            ProducerManager.ChangeName(i, newsurname);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Something went wrong.Try Again.");
                                                       break;
                                                }
                                                break;
                                                
                                            case "D":
                                                Console.Write("Write Producer's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    ProducerManager.Delete(i);
                                                    Console.WriteLine();
                                                }
                                                catch 
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "GetAll":
                                                ProducerManager.All();
                                                break;

                                            case "GetBy":
                                                Console.Write("Write Producer's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    ProducerManager.GetBy(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Something went wrong.Try Again.");
                                                break;
                                        }

                                    }
                                    break;
                                case "C":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Company, enter A{0}If you would like to Change Company, enter C{0}If you would like to Delete Company, enter D{0}If you would like to Get All Companies, enter GetAll{0}If you would like to Get Company By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                    }
                                    break;
                                case "G":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Genre, enter A{0}If you would like to Change Genre, enter C{0}If you would like to Delete Genre, enter D{0}If you would like to Get All Genries, enter GetAll{0}If you would like to Get Genre By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                    }
                                    break;
                                case "F":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Film, enter A{0}If you would like to Change  information about Film, enter C{0}If you would like to Delete Film, enter D{0}If you would like to Get All Films, enter GetAll{0}If you would like to Get Film By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                    }
                                    break;
                                case "return":
                                    manager = "return";
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Something went wrong. Try Again.");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        break;
                    case "S":
                        Console.WriteLine("Seacher?");
                        break;
                    case "finish":
                        person = "finish";
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
