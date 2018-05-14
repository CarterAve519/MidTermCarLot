using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermCarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome statement
            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");

            //Prompts user to enter number of cars and get user input.
            Console.WriteLine("How many cars are you entering:");
            int carCount;
            //Converting string to int using TryParse. Keyword out in front of variable. 
            int.TryParse(Console.ReadLine(), out carCount);

            //Building an array of car objects.
            Car[] cars = new Car[carCount];

            //Getting user input for the car field. 
            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine($"Enter Car {i + 1} Make:");
                string make = Console.ReadLine();

                Console.WriteLine($"Enter Car {i + 1} Model:");
                string model = Console.ReadLine();

                Console.WriteLine($"Enter Car {i + 1} Year:");
                int year;
                int.TryParse(Console.ReadLine(), out year);

                Console.WriteLine($"Enter car {i + 1} Price:");
                double price;
                double.TryParse(Console.ReadLine(), out price);

                //use the value constructor to intitialize car and car array.
                cars[i] = new Car(make, model, year, price);

            }
            Console.WriteLine("Current Inventory");
            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }


            ArrayList ListOfCars = new ArrayList();
            {

            }

            Console.WriteLine("Welcome to the Grand Circus Motors");
            Console.WriteLine( );

            

        }
    }
}
