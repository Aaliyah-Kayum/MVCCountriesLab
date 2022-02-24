using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent} {DisplayCountry.Color}");
        }
    }
}
