using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class ProducerManager
    {
        public static List<Producer> producers = new List<Producer>();

        public static void Add(int id, string name, string surname)
        {
            if (producers.FindIndex( x => x.id == id) == -1) 
            {
                producers.Add(new Producer(id, name, surname));
                return;
            }
            Console.WriteLine("This Id was already used for another Producer");
        }

        public static void Change(int id, int newid)
        {
            if (producers.FindIndex(x => x.id == newid) != -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = producers.FindIndex(x => x.id == id);
            try
            {
                producers[ind].id = newid;
            }
            catch
            {
                Console.WriteLine("Couldn't change Producer's id");
            }
        }

        public static void ChangeName(int id, string newname)
        {
            if (producers.FindIndex(x => x.id == id) == -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = producers.FindIndex(x => x.id == id);
            try
            {
                producers[ind].name = newname;
            }
            catch
            {
                Console.WriteLine("Couldn't change Producer's name");
            }
        }

        public static void ChangeSurame(int id, string newsurname)
        {
            if (producers.FindIndex(x => x.id == id) == -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = producers.FindIndex(x => x.id == id);
            try
            {
                producers[ind].surname = newsurname;
            }
            catch
            {
                Console.WriteLine("Couldn't change Producer's surname");
            }
        }

        public static void Delete(int id)
        {
            int ind = producers.FindIndex(x => x.id == id);
            try
            {
                producers.RemoveAt(ind);
            }
            catch
            {
                Console.WriteLine("Couldn't delete Producer");
            }
        }

        public static void GetBy(int id)
        {
            int i = producers.FindIndex(x => x.id == id);
            try
            {
                Console.WriteLine($"{producers[i].id} {producers[i].name} {producers[i].surname}");
            }
            catch
            {
                Console.WriteLine("Couldn't get element");
            }
        }

        public static void All()
        {
            for (int i = 0; i < producers.Count; ++i)
            {
                Console.WriteLine($"{i + 1}) {producers[i].id} {producers[i].name} {producers[i].surname}");
            }
        }
    }
}
