using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class Producer: Parent
    {
        public Producer(int i, string n, string s) 
        {
            id = i;
            name = n;
            surname = s;
        }
    }
}
