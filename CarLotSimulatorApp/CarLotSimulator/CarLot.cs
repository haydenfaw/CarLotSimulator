using System;
using System.Collections.Generic;
using System.Text;

//DONE -- Create a CarLot class
//DONE -- It should have at least one property: a List of cars
//DONE -- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ListOfCars = new List<Car>();
    }
}
