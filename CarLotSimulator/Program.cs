using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var myCar = new Car();
            myCar.Year = 2020;
            myCar.Make = "Lexus";
            myCar.Model = "Lx560";
            myCar.EngineNoise = "Broom_Broom";
            myCar.HonkNoise = "peep-peep";
            myCar.IsDriveable = true;
            
            lot.Cars.Add(myCar);

            var HenyCar = new Car
            {
                Year = 1968,
                Make = "BMW",
                Model = "M600",
                EngineNoise = "Groooooh-Grooooh",
                HonkNoise = "Pop-Pop",
                IsDriveable = false
            };
            lot.Cars.Add(HenyCar);

            var RiriCar = new Car(2019, "Kia", "Telluride", "Shhhhhhhh", "Beep-Beep", true);
            lot.Cars.Add(RiriCar);
            //Set the properties for each of the cars

            //Call each of the methods for each car

            myCar.MakeEngineNoise(myCar.EngineNoise);
            HenyCar.MakeEngineNoise(HenyCar.EngineNoise);
            RiriCar.MakeEngineNoise(RiriCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            HenyCar.MakeHonkNoise(HenyCar.HonkNoise);
            RiriCar.MakeHonkNoise(RiriCar.HonkNoise);

            Console.WriteLine("The group of cars which has most features in our dealershop :");
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"year:{car.Year}, Make :{car.Make}, Model :{car.Model}, EngineNoise :{car.EngineNoise} ,HonkNoise :{car.HonkNoise}, IsDriable :{car.IsDriveable}");
            }

            var carList = new List<Car>() {myCar, HenyCar, RiriCar};
            Console.WriteLine(value: carList.Capacity);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
