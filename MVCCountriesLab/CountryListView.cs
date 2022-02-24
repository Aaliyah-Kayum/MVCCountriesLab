using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set;}
        public int Number { get; set; }
        public void Display()
        {
            string Name = null;
            Console.WriteLine($"{Name}");
        }
    }
}
