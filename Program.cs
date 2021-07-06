using System;
using Vehicles;

namespace GarageProject
{
    class Program
    {


        const int capacity = 5; // NEEDS to be a constant to be passed to constructor.
        static Garage<Vehicle> myGarage = new Garage<Vehicle>(capacity);
        static Vehicle myCar = new("FCV268", "Pink", 4);
        static Vehicle myBike = new(null, "Black", 2);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(myCar.ToString());             
            


        }

        

        


        //private static void SeedData()
        //{
        //    myGarage.AddVehicle("id", "color", wheels);

        //}



    }
}
