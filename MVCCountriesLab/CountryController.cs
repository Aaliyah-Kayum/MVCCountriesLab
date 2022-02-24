using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        List<Country> CountryDb = new List<Country>();
        public CountryController()
        {
            CountryDb = new List<Country>()
            {
                new Country("Red"), 
                new Country("Blue"),
                new Country("White"), 
                new Country("Green"), 
                new Country("Black"), 
                new Country("Yellow")

            };
        }
        public void WelcomeAction()
        { 
                CountryDb = new List<Country>();
            {
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                {
                    new Country() { Number = 1, Name = "US", Colors = "Red, White, Blue" };
                    new Country() { Number = 2, Name = "UK", Colors = "Red, White, Blue" };
                    new Country() { Number = 3, Name = "Japan", Colors = "Red, White" };
                    new Country() { Number = 4, Name = "Germany", Colors = "Black, Red, Yellow" };
                    new Country() { Number = 5, Name = "Italy", Colors = "Green, White, Red" };
                    new Country() { Number = 6, Name = "France", Colors = "White, Blue, Red" };
                }
            }
        }

        public void CountryAction(Country c)
        {
            Console.WriteLine("");
        }

        //public void WelcomeAction()
        //{
        //    Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
        //    Console.WriteLine();
        //}

        public void DisplayCountry()
        {
            foreach (Country c in CountryDb)
            {
                CountryView view = new CountryView(c);
                view.Display();  
            }
        }
    }
}
