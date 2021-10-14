using Classes_OOP.Finished_product;
using System;
using System.Collections.Generic;

namespace Classes_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ToyotaSupra = new Car(new Engine(387, 2998, "Gasoline", "B58B30"), new Chassis(4, "A58A30", 1450), new Transmission("Automatic", 8, "Toyota"), "Red", "Passion");
            Car AudiR8 = new Car(new Engine(540, 5204, "Gasoline", "ADVIGB"), new Chassis(4, "B58B30", 1595), new Transmission("Automatic", 7, "Audi"), "Gray", "Coupe");

            Truck MAZ_5340C5_8520_000 = new Truck(new Engine(330, 53603, "Gasoline", "ЯМЗ-53603.10"), new Chassis(8, "C58C30", 44000), new Transmission("Mechanical", 9, "MAZ"), "Green", "flatbed");

            Bus VANhool915 = new Bus(new Engine(450, 11900, "Gasoline", "Cummins ISX12"), new Chassis(8, "D58D30", 35000), new Transmission("Mechanical", 12, "ZF 12AS2301BO"), "White", 50);

            Scooter RacerMeteor = new Scooter(new Engine(3.4, 49.5, "Gasoline", "RACER"), new Chassis(2, "E58E30", 250), new Transmission("Mechanical", 4, "JVSBF25"), "Blue", "Telescopic");
            Scooter VentoRetro = new Scooter(new Engine(2.2, 49, "Gasoline", "Vento"), new Chassis(2, "F58F30", 245), new Transmission("Mechanical", 4, "CHINDVK"), "Yellow", "lever");


            Console.WriteLine("Hello, you are welcomed by the Minsk automobile salon 'Minsk Automobile Salon'!");
            Console.WriteLine("We have in stock");

            Console.WriteLine("Cars:");
            Console.WriteLine("_________" + nameof(ToyotaSupra) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {ToyotaSupra._engine.power} \n Volume: {ToyotaSupra._engine.volume} \n Type: {ToyotaSupra._engine.type} \n Serial number: {ToyotaSupra._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {ToyotaSupra._chassis.wheelsNumber} \n Number: {ToyotaSupra._chassis.number} \n Permissible load: {ToyotaSupra._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {ToyotaSupra._transmission.type} \n Gears number: {ToyotaSupra._transmission.gearsNumber} \n Producer: {ToyotaSupra._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {ToyotaSupra.frameColor} \n Body type: {ToyotaSupra.bodyType}");
            Console.WriteLine();
            Console.WriteLine("_________" + nameof(AudiR8) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {AudiR8._engine.power} \n Volume: {AudiR8._engine.volume} \n Type: {AudiR8._engine.type} \n Serial number: {AudiR8._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {AudiR8._chassis.wheelsNumber} \n Number: {AudiR8._chassis.number} \n Permissible load: {AudiR8._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {AudiR8._transmission.type} \n Gears number: {AudiR8._transmission.gearsNumber} \n Producer: {AudiR8._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {AudiR8.frameColor} \n Body type: {AudiR8.bodyType}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Buses:");
            Console.WriteLine("_________" + nameof(VANhool915) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {VANhool915._engine.power} \n Volume: {VANhool915._engine.volume} \n Type: {VANhool915._engine.type} \n Serial number: {VANhool915._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {VANhool915._chassis.wheelsNumber} \n Number: {VANhool915._chassis.number} \n Permissible load: {VANhool915._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {VANhool915._transmission.type} \n Gears number: {VANhool915._transmission.gearsNumber} \n Producer: {VANhool915._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {VANhool915.frameColor} \n Passengers Number: {VANhool915.passengersNumber}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Trucks:");
            Console.WriteLine("_________" + nameof(MAZ_5340C5_8520_000) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {MAZ_5340C5_8520_000._engine.power} \n Volume: {MAZ_5340C5_8520_000._engine.volume} \n Type: {MAZ_5340C5_8520_000._engine.type} \n Serial number: {MAZ_5340C5_8520_000._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {MAZ_5340C5_8520_000._chassis.wheelsNumber} \n Number: {MAZ_5340C5_8520_000._chassis.number} \n Permissible load: {MAZ_5340C5_8520_000._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {MAZ_5340C5_8520_000._transmission.type} \n Gears number: {MAZ_5340C5_8520_000._transmission.gearsNumber} \n Producer: {MAZ_5340C5_8520_000._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {MAZ_5340C5_8520_000.frameColor} \n Body type: {MAZ_5340C5_8520_000.bodyType}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scooters:");
            Console.WriteLine("_________" + nameof(RacerMeteor) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {RacerMeteor._engine.power} \n Volume: {RacerMeteor._engine.volume} \n Type: {RacerMeteor._engine.type} \n Serial number: {RacerMeteor._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {RacerMeteor._chassis.wheelsNumber} \n Number: {RacerMeteor._chassis.number} \n Permissible load: {RacerMeteor._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {RacerMeteor._transmission.type} \n Gears number: {RacerMeteor._transmission.gearsNumber} \n Producer: {RacerMeteor._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {RacerMeteor.frameColor} \n Front fork: {RacerMeteor.frontFork}");
            Console.WriteLine();
            Console.WriteLine("_________" + nameof(VentoRetro) + "_________");
            Console.WriteLine("---Engine characteristics");
            Console.WriteLine($" Power: {VentoRetro._engine.power} \n Volume: {VentoRetro._engine.volume} \n Type: {VentoRetro._engine.type} \n Serial number: {VentoRetro._engine.serialNumber}");
            Console.WriteLine("---Chassis characteristics");
            Console.WriteLine($" Wheels Number: {VentoRetro._chassis.wheelsNumber} \n Number: {VentoRetro._chassis.number} \n Permissible load: {VentoRetro._chassis.permissible_load}");
            Console.WriteLine("---Transmission characteristics");
            Console.WriteLine($" Type: {VentoRetro._transmission.type} \n Gears number: {VentoRetro._transmission.gearsNumber} \n Producer: {VentoRetro._transmission.producer}");
            Console.WriteLine("---Other characteristics");
            Console.WriteLine($" Frame color: {VentoRetro.frameColor} \n Front fork: {VentoRetro.frontFork}");
        }
    }
}
