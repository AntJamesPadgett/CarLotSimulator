using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

           
            //TODO

            //DONE-Create a seperate class file called Car
            //DONE-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE_Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE-The methods should take one string parameter: the respective noise property


            //DONE-Now that the Car class is created we can instanciate 3 new cars
           
            //DONE-Set the properties for each of the cars
            //DONE-Call each of the methods for each car

            //Dot-notation
            var tonysCar = new Car();
            tonysCar.Make = "Mazda";
            tonysCar.Model = "Millenia";
            tonysCar.Year = 2001;
            tonysCar.EngineNoise = "vroom";
            tonysCar.HonkNoise = "beep";
            tonysCar.IsDrivable = true;

            lot.Cars.Add(tonysCar);

            //Object-Intializer syntax
            var kokosCar = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 1998,
                EngineNoise = "...",
                HonkNoise = "brmp",
                IsDrivable = false,
            };
            lot.Cars.Add(kokosCar);

            //Using the constructor
            var kyreesCar = new Car("Tesla", "Bike", 2021, "wzzzzzz", "beeeeep", "true");

            lot.Cars.Add(kyreesCar);


            tonysCar.MakeEngineNoise(tonysCar.EngineNoise);
            kokosCar.MakeEngineNoise(kokosCar.EngineNoise);
            kyreesCar.MakeEngineNoise(kyreesCar.EngineNoise);

            






            //*************BONUS*************//

            // DONE-Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE-Create a CarLot class
            //DONE-It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
