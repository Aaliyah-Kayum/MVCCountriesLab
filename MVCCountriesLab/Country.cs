using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class Country
    {
        public Country()
        {
        }

        public Country(string v)
        {
        }
        public string Name { get; set; }    
        public string Continent { get; set; }
        public List<string> Color { get; set; }
        public string Colors { get; set; }   
        public int Number { get; internal set; }
    }
}
