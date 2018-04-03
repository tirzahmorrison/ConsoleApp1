using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numOfDogs = 10;
            byte numOfSandwiches = 1;
            float costOfDinner = 4.25f;
            string favColor = "red";
            string favMake = "tesla";
            String favModel = "s";
            DateTime todayDate = DateTime.Now;
            char firstInitial = 't';
            ulong numStars = 1000000000000; 
            string numStars2 = "billions upon billions";
            decimal numStars3 = 1e12M;
            Console.WriteLine("there are {0} dogs in the park", numOfDogs);
            Console.WriteLine("I can eat {0} sandwiches when I'm hungry", numOfSandwiches);
            Console.WriteLine("Dinner cost ${0}", costOfDinner);
            Console.WriteLine("The color of my dream car is {0}", favColor);
            Console.WriteLine("The make of my dream car is a {0}", favMake);
            Console.WriteLine("The model of my dream car is {0}", favModel);
            Console.WriteLine("Today's date is {0}", todayDate.ToString("MM-dd-yyyy"));
            Console.WriteLine("The first initial of my name is {0}", firstInitial);
            Console.WriteLine("There are {0} of stars in the galaxy", numStars);
            Console.WriteLine("According to Carl Sagan, there are {0} of stars in the galaxy", numStars2);
            Console.WriteLine("There are approximatly {0} of stars in the galaxy", numStars3);
            Console.ReadLine();

            
        }
    }
}
