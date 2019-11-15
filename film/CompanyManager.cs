using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class CompanyManager
    {
        public static List<Company> companies = new List<Company>();

        public static void Add(int id, string name)
        {
            if (companies.FindIndex(x => x.id == id) == -1)
            {
                companies.Add(new Company(id, name));
                return;
            }
            Console.WriteLine("This Id was already used for another Company");
        }

        public static void Change(int id, int newid)
        {
            if (companies.FindIndex(x => x.id == newid) != -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = companies.FindIndex(x => x.id == id);
            try
            {
                companies[ind].id = newid;
            }
            catch
            {
                Console.WriteLine("Couldn't change Company's id");
            }
        }

        public static void ChangeName(int id, string newname)
        {
            if (companies.FindIndex(x => x.id == id) == -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = companies.FindIndex(x => x.id == id);
            try
            {
                companies[ind].name = newname;
            }
            catch
            {
                Console.WriteLine("Couldn't change Company's name");
            }
        }

        public static void Delete(int id)
        {
            int ind = companies.FindIndex(x => x.id == id);
            try
            {
                companies.RemoveAt(ind);
            }
            catch
            {
                Console.WriteLine("Couldn't delete Company");
            }
        }

        public static void GetBy(int id)
        {
            int i = companies.FindIndex(x => x.id == id);
            try
            {
                Console.WriteLine($"{companies[i].id} {companies[i].name}");
            }
            catch
            {
                Console.WriteLine("Couldn't get element");
            }
        }

        public static void All()
        {
            for (int i = 0; i < companies.Count; ++i)
            {
                Console.WriteLine($"{i + 1}) {companies[i].id} {companies[i].name}");
            }
        }
    }
}
