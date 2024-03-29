﻿using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class FilmManager
    {
        public static List<Film> films = new List<Film>();

        public static void AddCh(int id, string name, string des, int prod, int comp, int genre, int day, int mon, int year)
        {
            if (ProducerManager.producers.FindIndex(x => x.id == prod) == -1)
            {
                Console.WriteLine("Write Producer's name: ");
                string pname = Console.ReadLine();
                Console.WriteLine("Write Producer's surname: ");
                string surname = Console.ReadLine();
                try
                {
                    ProducerManager.Add(id, pname, surname);
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Something went wrong.Try Again.");
                }
            }

            if (CompanyManager.companies.FindIndex(x => x.id == comp) == -1)
            {

                Console.WriteLine("Write Company's name: ");
                string cname = Console.ReadLine();
                try
                {
                    CompanyManager.Add(id, cname);
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Something went wrong.Try Again.");
                }
               
            }

            if (GenreManager.genres.FindIndex(x => x.id == genre) == -1)
            {
                Console.WriteLine("Write genre ");
                string gname = Console.ReadLine();
                try
                {
                    GenreManager.Add(id, gname);
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Something went wrong.Try Again.");
                }

            }

            FilmManager.Add(id, name, des, prod, comp, genre, day, mon, year);

        }

        public static void Add(int id, string name, string des, int prod, int comp, int genre, int day, int mon, int year)
        { 
            if (films.FindIndex(x => x.id == id) == -1 && ProducerManager.producers.FindIndex(x => x.id == prod) != -1 && CompanyManager.companies.FindIndex(x => x.id == comp) != -1 && GenreManager.genres.FindIndex(x => x.id == genre) != -1)
            {
                try
                {
                    DateTime relisedate = new DateTime(year,mon,day);
                    films.Add(new Film(id, name, des, relisedate, prod, comp, genre));
                    return;
                }
                catch
                {
                    Console.WriteLine("Couldn't add film");
                }
            }
            Console.WriteLine("Couldn't add film");
        }

        public static void Change(int id, int newid)
        {
            if (films.FindIndex(x => x.id == newid) != -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = films.FindIndex(x => x.id == id);
            try
            {
                films[ind].id = newid;
            }
            catch
            {
                Console.WriteLine("Couldn't change film's id");
            }
        }

        public static void ChangeName(int id, string newname)
        {
            if (films.FindIndex(x => x.id == id) == -1)
            {
                Console.WriteLine("Invalid id to change");
                return;
            }
            int ind = films.FindIndex(x => x.id == id);
            try
            {
                films[ind].name = newname;
            }
            catch
            {
                Console.WriteLine("Couldn't change film's name");
            }
        }

        public static void Delete(int id)
        {
            int ind = films.FindIndex(x => x.id == id);
            try
            {
                films.RemoveAt(ind);
            }
            catch
            {
                Console.WriteLine("Couldn't delete film");
            }
        }

        public static void GetBy(int id)
        {
            int i = films.FindIndex(x => x.id == id);
            try
            {
                Console.WriteLine($"{films[i].id}, {films[i].name}, {films[i].description}, {films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == films[i].producer_id).name}, {CompanyManager.companies.Find(x => x. id == films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == films[i].genre_id).name}");
            }
            catch
            {
                Console.WriteLine("Couldn't get element");
            }
        }

        public static void All()
        {
            for (int i = 0; i < films.Count; ++i)
            {
                Console.WriteLine($"{i+1}) {films[i].id}, {films[i].name}, {films[i].description}, {films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == films[i].producer_id).name}, {CompanyManager.companies.Find(x => x.id == films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == films[i].genre_id).name}");
            }
        }
    }
}

