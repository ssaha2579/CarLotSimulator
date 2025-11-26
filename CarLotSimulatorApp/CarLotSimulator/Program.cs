using System;
using System.Collections.Generic;

namespace CarLotSimulator 
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var carLot = new CarLot();
            //TODO
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var CarOne = new Car();
            CarOne.Make = "Tesla";
            CarOne.Model = "Model Y Long Range";
            CarOne.Year = 2021;
            CarOne.IsDrivable = true;

            CarOne.MakeEngineNoise("Vroom");
            CarOne.MakeHonkNoise("Honk"); 
            
            carLot.ParkingLot.Add(CarOne);
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}");
            
            var CarTwo = new Car()
            {
                Make = "Jeep",
                Model = "Wrangler",
                Year = 2014,
                IsDrivable = false, 
            };

            CarTwo.MakeEngineNoise("rattle-rattle"); 
            CarTwo.MakeHonkNoise("Beep");

            carLot.ParkingLot.Add(CarTwo);
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}"); 

            var CarThree = new Car("Lexus", "RZ", 2025, true);
            
            CarThree.MakeEngineNoise("Swoosh");

            carLot.ParkingLot.Add(CarThree);
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}");
            


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to 
            
            carLot.CheckCars();
            
        }
    }
}
