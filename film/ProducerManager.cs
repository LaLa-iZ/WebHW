﻿using System;
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
    }
}