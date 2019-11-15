using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class FilmSeacher
    {
        public static void SearchById(int id)
        {
            FilmManager.GetBy(id);
        }

        public static void SearchByDate(DateTime date)
        {
            int k = 1;
            for (int i = 0; i < FilmManager.films.Count; ++i)
            {
                if (FilmManager.films[i].realisedate == date)
                {
                    Console.WriteLine($"{k}) {FilmManager.films[i].id}, {FilmManager.films[i].name}, {FilmManager.films[i].description}, {FilmManager.films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).name}, {CompanyManager.companies.Find(x => x.id == FilmManager.films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == FilmManager.films[i].genre_id).name}");
                    k++;
                }
            }

            if (k == 1) { Console.WriteLine("No films on this date"); };
        }

        public static void SearchByProd(string name, string surname)
        {
            int k = 1;
            for (int i = 0; i < FilmManager.films.Count; ++i)
            {
                if (ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).name == name && ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).surname == surname)
                {
                    Console.WriteLine($"{k}) {FilmManager.films[i].id}, {FilmManager.films[i].name}, {FilmManager.films[i].description}, {FilmManager.films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).name}, {CompanyManager.companies.Find(x => x.id == FilmManager.films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == FilmManager.films[i].genre_id).name}");
                    k++;
                }
            }

            if (k == 1) { Console.WriteLine("No films from that producer"); };
        }

        public static void SearchByComp(string name)
        {
            int k = 1;
            for (int i = 0; i < FilmManager.films.Count; ++i)
            {
                if (CompanyManager.companies.Find(x => x.id == FilmManager.films[i].company_id).name == name)
                {
                    Console.WriteLine($"{k}) {FilmManager.films[i].id}, {FilmManager.films[i].name}, {FilmManager.films[i].description}, {FilmManager.films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).name}, {CompanyManager.companies.Find(x => x.id == FilmManager.films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == FilmManager.films[i].genre_id).name}");
                    k++;
                }
            }

            if (k == 1) { Console.WriteLine("No films from that company"); };
        }

        public static void SearchByGenre(string name)
        {
            int k = 1;
            for (int i = 0; i < FilmManager.films.Count; ++i)
            {
                if (GenreManager.genres.Find(x => x.id == FilmManager.films[i].genre_id).name == name)
                {
                    Console.WriteLine($"{k}) {FilmManager.films[i].id}, {FilmManager.films[i].name}, {FilmManager.films[i].description}, {FilmManager.films[i].realisedate}, {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).surname} {ProducerManager.producers.Find(x => x.id == FilmManager.films[i].producer_id).name}, {CompanyManager.companies.Find(x => x.id == FilmManager.films[i].company_id).name}, {GenreManager.genres.Find(x => x.id == FilmManager.films[i].genre_id).name}");
                    k++;
                }
            }

            if (k == 1) { Console.WriteLine("No films of that genre"); };
        }
    }
}
