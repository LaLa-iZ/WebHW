using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class Film
    {
        public int id;
        public string name;
        public string description;
        public DateTime realisedate;
        public int producer_id;
        public int company_id;
        public int genre_id;
        public Film(int i, string n, string d, DateTime r, int p, int c, int g)
        {
            id = i;
            name = n;
            description = d;
            realisedate = r;
            producer_id = p;
            company_id = c;
            genre_id = g;
    }
    }
}
