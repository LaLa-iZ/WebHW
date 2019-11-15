using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class GenreManager
    {
        public static List<Genre> genres = new List<Genre>();

        public static void Add(int id, string name)
        {
            if (genres.FindIndex(x => x.id == id) == -1)
            {
                genres.Add(new Genre(id, name));
                return;
            }
            Console.WriteLine("This Id was already used for another Genre");
        }

        public static void Change(int id, int newid)
        {
            if (genres.FindIndex(x => x.id == newid) != -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = genres.FindIndex(x => x.id == id);
            try
            {
                genres[ind].id = newid;
            }
            catch
            {
                Console.WriteLine("Couldn't change Genre's id");
            }
        }

        public static void ChangeName(int id, string newname)
        {
            if (genres.FindIndex(x => x.id == id) == -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = genres.FindIndex(x => x.id == id);
            try
            {
                genres[ind].name = newname;
            }
            catch
            {
                Console.WriteLine("Couldn't change Genre's name");
            }
        }

        public static void Delete(int id)
        {
            int ind = genres.FindIndex(x => x.id == id);
            try
            {
                genres.RemoveAt(ind);
            }
            catch
            {
                Console.WriteLine("Couldn't delete Genre");
            }
        }

        public static void GetBy(int id)
        {
            int i = genres.FindIndex(x => x.id == id);
            try
            {
                Console.WriteLine($"{genres[i].id} {genres[i].name}");
            }
            catch
            {
                Console.WriteLine("Couldn't get element");
            }
        }

        public static void All()
        {
            for (int i = 0; i < genres.Count; ++i)
            {
                Console.WriteLine($"{i + 1}) {genres[i].id} {genres[i].name}");
            }
        }
    }
}
