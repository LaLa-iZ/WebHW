using System;

namespace film
{
    class MainPage
    {
        static void Main(string[] args)
        {
            Check.Filler();
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

                                            case "return":
                                                Console.WriteLine();
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
                                        string id;
                                        switch (method)
                                        {
                                            case "A":
                                                Console.WriteLine("Write Company id: ");
                                                id = Console.ReadLine();
                                                Console.WriteLine("Write Company's name: ");
                                                string name = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    CompanyManager.Add(i, name);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "C":
                                                Console.WriteLine("If you whant to change id, enter id{0}If you whant to change name, enter name{0}", Environment.NewLine);
                                                string change = Console.ReadLine();
                                                switch (change)
                                                {
                                                    case "id":
                                                        Console.Write("Write Company's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Company's id: ");
                                                        string newid = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            int newi = Convert.ToInt32(newid);
                                                            CompanyManager.Change(i, newi);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    case "name":
                                                        Console.Write("Write Company's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Company's name: ");
                                                        string newname = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            CompanyManager.ChangeName(i, newname);
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
                                                Console.Write("Write Company's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    CompanyManager.Delete(i);
                                                    Console.WriteLine();
                                                }
                                                catch 
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "GetAll":
                                                CompanyManager.All();
                                                break;

                                            case "GetBy":
                                                Console.Write("Write Company's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    CompanyManager.GetBy(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "return":
                                                Console.WriteLine();
                                                break;

                                            default:
                                                Console.WriteLine("Something went wrong.Try Again.");
                                                break;
                                        }
                                    }
                                    break;
                                case "G":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Genre, enter A{0}If you would like to Change Genre, enter C{0}If you would like to Delete Genre, enter D{0}If you would like to Get All Genres, enter GetAll{0}If you would like to Get Genre By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                        string id;
                                        switch (method)
                                        {
                                            case "A":
                                                Console.WriteLine("Write Genre id: ");
                                                id = Console.ReadLine();
                                                Console.WriteLine("Write Genre's name: ");
                                                string name = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    GenreManager.Add(i, name);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "C":
                                                Console.WriteLine("If you whant to change id, enter id{0}If you whant to change name, enter name{0}", Environment.NewLine);
                                                string change = Console.ReadLine();
                                                switch (change)
                                                {
                                                    case "id":
                                                        Console.Write("Write Genre's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Genre's id: ");
                                                        string newid = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            int newi = Convert.ToInt32(newid);
                                                            GenreManager.Change(i, newi);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    case "name":
                                                        Console.Write("Write Genre's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Genre's name: ");
                                                        string newname = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            GenreManager.ChangeName(i, newname);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                            Console.WriteLine();
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Something went wrong.Try Again.");
                                                        Console.WriteLine();
                                                        break;
                                                }
                                                break;

                                            case "D":
                                                Console.Write("Write Genre's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    GenreManager.Delete(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                    Console.WriteLine();
                                                }
                                                break;

                                            case "GetAll":
                                                GenreManager.All();
                                                break;

                                            case "GetBy":
                                                Console.Write("Write Genre's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    GenreManager.GetBy(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                    Console.WriteLine();
                                                }
                                                break;

                                            case "return":
                                                Console.WriteLine();
                                                break;

                                            default:
                                                Console.WriteLine("Something went wrong.Try Again.");
                                                Console.WriteLine();
                                                break;
                                        }
                                        }
                                    break;
                                case "F":
                                    while (method != "return")
                                    {
                                        Console.WriteLine("What would you do?{0}If you would like to Add Film, enter A{0}If you would like to Change  information about Film, enter C{0}If you would like to Delete Film, enter D{0}If you would like to Get All Films, enter GetAll{0}If you would like to Get Film By Id, enter GetBy{0}If you whant to return, enter return ", Environment.NewLine);
                                        method = Console.ReadLine();
                                        string id;
                                        switch (method)
                                        {
                                            case "A":
                                                //int id, string name, string des, int prod, int comp, int genre, int day, int mon, int year
                                                Console.WriteLine("Write Film id: ");
                                                id = Console.ReadLine();
                                                Console.WriteLine("Write Film's name: ");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Write Film's description: ");
                                                string desc = Console.ReadLine();
                                                Console.WriteLine("Write id producer: ");
                                                string prod = Console.ReadLine();
                                                Console.WriteLine("Write id of the company: ");
                                                string comp = Console.ReadLine();
                                                Console.WriteLine("Write id genre: ");
                                                string genre = Console.ReadLine();
                                                Console.WriteLine("Write Film's day relise: ");
                                                string day = Console.ReadLine();
                                                Console.WriteLine("Write Film's month relise: ");
                                                string mon = Console.ReadLine();
                                                Console.WriteLine("Write Film's year relise: ");
                                                string year = Console.ReadLine();

                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    int c = Convert.ToInt32(comp);
                                                    int p = Convert.ToInt32(prod);
                                                    int g = Convert.ToInt32(genre);
                                                    int d = Convert.ToInt32(day);
                                                    int m = Convert.ToInt32(mon);
                                                    int y = Convert.ToInt32(year);
                                                    FilmManager.AddCh(i, name, desc, p, c, g, d, m, y);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                }
                                                break;

                                            case "C":
                                                Console.WriteLine("If you whant to change id, enter id{0}If you whant to change name, enter name{0}", Environment.NewLine);
                                                string change = Console.ReadLine();
                                                switch (change)
                                                {
                                                    case "id":
                                                        Console.Write("Write Film's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Film's id: ");
                                                        string newid = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            int newi = Convert.ToInt32(newid);
                                                            FilmManager.Change(i, newi);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                        }
                                                        break;
                                                    case "name":
                                                        Console.Write("Write Film's id: ");
                                                        id = Console.ReadLine();
                                                        Console.Write("Write new Film's name: ");
                                                        string newname = Console.ReadLine();
                                                        try
                                                        {
                                                            int i = Convert.ToInt32(id);
                                                            FilmManager.ChangeName(i, newname);
                                                            Console.WriteLine();
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Something went wrong.Try Again.");
                                                            Console.WriteLine();
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Something went wrong.Try Again.");
                                                        Console.WriteLine();
                                                        break;
                                                }
                                                break;

                                            case "D":
                                                Console.Write("Write Film's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    FilmManager.Delete(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                    Console.WriteLine();
                                                }
                                                break;

                                            case "GetAll":
                                                FilmManager.All();
                                                break;

                                            case "GetBy":
                                                Console.Write("Write Film's id: ");
                                                id = Console.ReadLine();
                                                try
                                                {
                                                    int i = Convert.ToInt32(id);
                                                    FilmManager.GetBy(i);
                                                    Console.WriteLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Something went wrong.Try Again.");
                                                    Console.WriteLine();
                                                }
                                                break;
                                            case "return":
                                                Console.WriteLine();
                                                break;

                                            default:
                                                Console.WriteLine("Something went wrong.Try Again.");
                                                Console.WriteLine();
                                                break;
                                        }
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
                        string search = "nothing";
                        while(search != "return")
                        {
                            Console.WriteLine("If you whant to search film by id, enter id{0}If you whant to search film by realise date, enter date{0}If you whant to search film by producer, enter producer{0}If you whant to search film by genre, enter genre{0}If you whant to search film by company, enter company{0}", Environment.NewLine);
                            search = Console.ReadLine();

                            switch (search)
                            {
                                case "id":
                                    Console.WriteLine("Write film id: ");
                                    string fid = Console.ReadLine();
                                    try
                                    {
                                        int i = Convert.ToInt32(fid);
                                        FilmSeacher.SearchById(i);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Something went wrong.Try Again.");
                                    }
                                    break;

                                case "date":
                                    Console.WriteLine("Write Film's day relise: ");
                                    string day = Console.ReadLine();
                                    Console.WriteLine("Write Film's month relise: ");
                                    string mon = Console.ReadLine();
                                    Console.WriteLine("Write Film's year relise: ");
                                    string year = Console.ReadLine();
                                    try
                                    {
                                        int d = Convert.ToInt32(day);
                                        int m = Convert.ToInt32(mon);
                                        int y = Convert.ToInt32(year);
                                        DateTime relisedate = new DateTime(y,m,d);
                                        FilmSeacher.SearchByDate(relisedate);
                                        return;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Couldn't find film");
                                    }
                                    break;

                                case "producer":
                                    Console.WriteLine("Write producer's name ");
                                    string prod = Console.ReadLine();
                                    Console.WriteLine("Write producer's surname ");
                                    string sprod = Console.ReadLine();
                                    try
                                    {
                                        FilmSeacher.SearchByProd(prod,sprod);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Couldn't find film");
                                    }
                                    break;

                                case "genre":
                                    Console.WriteLine("Write genre ");
                                    string gen = Console.ReadLine();
                                    try
                                    {
                                        FilmSeacher.SearchByGenre(gen);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Couldn't find film");
                                    }
                                    break;

                                case "company":
                                    Console.WriteLine("Write company's name ");
                                    string comp = Console.ReadLine();
                                    try
                                    {
                                        FilmSeacher.SearchByComp(comp);

                                    }
                                    catch
                                    {
                                        Console.WriteLine("Couldn't find film");
                                    }
                                    break;

                                case "return":
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Something went wrong. Try Again.");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        break;
                    case "finish":
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
