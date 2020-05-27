using System;
using System.Collections.Generic;
using System.Text;

namespace Kursovaya_var_12
{
    class Country
    {
        public string name;
        public string city;

        public Country(string a, string b)
        {
            name = a;
            city = b;
        }
    }

    class Agency
    {
        public string AgencyName;
        public int Show;

        public Agency(string a)
        {
            AgencyName = a;
            Show = 0;
        }
    }

    //Створити країну для курорту
    class Tours : Agency
    {
        public string counName;
        public string cityName;
        public string type;
        public int MonthSt;
        public int MonthEnd;

        public Tours(string a, Country place, string Ty, int st, int end)
            : base(a)
        {
            counName = place.name;
            cityName = place.city;
            type = Ty;
            MonthSt = st;
            MonthEnd = end;
        }
    }
}
