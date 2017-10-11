using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_and_creating_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);

            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.ReadLine();
        }

        private static double determineMarketValue(Car _car)
        {
            double carvalue = 100;

            return carvalue;
        }
    }
    // we are here creating an object that we can add properties to and call later
	class Car
    {
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }
		//Get and set for each property so it takes and sets and value for each
        //prop tab tab is really useful

		public double DetermineMarketValue() //This is how they do Console.WriteLine();
		{
			double carValue = 100;

			if (this.Year > 1990)
				carValue = 10000.0;
			else
				carValue = 2000.0; 
            //This example is simple but for more complicated ones created classes can be invaluable.
			return carValue;
		}


	}
}
