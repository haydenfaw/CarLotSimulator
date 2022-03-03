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

            //DONE -- Create a seperate class file called Car
            //DONE -- Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE -- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE -- The methods should take one string parameter: the respective noise property


            //DONE -- Now that the Car class is created we can instanciate 3 new cars
            //DONE -- Set the properties for each of the cars
            //DONE -- Car Inputs: public Car(int year, string make, string model)

            //Inputs to fill out: Make, Model, year, EngineNoise, HonkNoise, IsDriveable
            var jeep = new Car();
            jeep.Make = "Jeep";
            jeep.Model = "Patriot";
            jeep.Year = 2007;
            jeep.EngineNoise = "vroom";
            jeep.HonkNoise = "beep beep";
            jeep.IsDriveable = false;

            carLot.ListOfCars.Add(jeep);

            var tahoe = new Car()
            {
                Make = "Chevy",
                Model = "Tahoe",
                Year = 2019,
                EngineNoise = "Vroooom",
                HonkNoise = "Honk",
                IsDriveable = true
            };
            carLot.ListOfCars.Add(tahoe);

            //Inputs to fill out: public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
            var ford = new Car("Ford","Raptor",2022,"VROOOOMMM", "HONK HONK", true);
            carLot.ListOfCars.Add(ford);

            //print method
            jeep.MakeEngineNoise();
            jeep.MakeHonkNoise();
            tahoe.MakeEngineNoise();
            tahoe.MakeHonkNoise();
            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            //old
            /*var cars = new List<Car>() { jeep, tahoe, ford };

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year} {car.EngineNoise} {car.HonkNoise} {car.IsDriveable} ");
            }*/
            foreach (var car in carLot.ListOfCars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
            }


            //*************BONUS*************//

            //DONE -- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE -- Create a CarLot class
            //DONE -- It should have at least one property: a List of cars
            //DONE -- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE -- At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
