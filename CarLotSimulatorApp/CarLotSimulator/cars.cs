using System;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"Your {Make} {Model} has an engine noise that sounds like {engineNoise}.");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"Your {Make} {Model} honks like {honkNoise}!");
        }

        public Car()
        {
            CarLot.numberOfCars++; 
        }
        public Car(string carMake, string carModel, int carYear, bool carIsDrivable)
        {
            Make = carMake;
            Model = carModel;
            Year = carYear;
            IsDrivable = carIsDrivable;
            
            CarLot.numberOfCars++;
        }
    }
}
