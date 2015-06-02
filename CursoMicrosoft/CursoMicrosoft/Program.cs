using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMicrosoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Make = "Lamborghini";
            myNewCar.Model = "Aventador SV";
            myNewCar.Year = 2012;
            myNewCar.Color = "Black";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}


