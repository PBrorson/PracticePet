using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePet
{
    internal class PetWorld
    {
        public void Run()
        {
            Console.Title = "Virtual Pet Sim";
            Console.WriteLine(@"
 __      ___      _               _ _____     _   
 \ \    / (_)    | |             | |  __ \   | |  
  \ \  / / _ _ __| |_ _   _  __ _| | |__) |__| |_ 
   \ \/ / | | '__| __| | | |/ _` | |  ___/ _ \ __|
    \  /  | | |  | |_| |_| | (_| | | |  |  __/ |_ 
     \/   |_|_|   \__|\__,_|\__,_|_|_|   \___|\__|
                                                  
                                                  
    ");

            Console.WriteLine("Welcome to the PetSimulator!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            VirtualPet leoTheCat = new VirtualPet("Leo", 12, "Cat", true, 33);

            Console.WriteLine(">PET1");
            leoTheCat.Greet();
            leoTheCat.Sleep();
            leoTheCat.Eat("Dryfood");



            Console.WriteLine("");
            VirtualPet juniorTheParrot = new VirtualPet("Junior", 50, "Parrot", false, 55);


            Console.WriteLine(">PET2");
            juniorTheParrot.Greet();
            juniorTheParrot.Sleep();
            juniorTheParrot.Eat("Dry nuts!");
            Console.WriteLine("");


            VirtualPet CallietheUnicorn = new VirtualPet("Callie", 250, "Unicorn", true, 22);

            Console.WriteLine(">PET3");
            CallietheUnicorn.Greet();
            CallietheUnicorn.Sleep();
            CallietheUnicorn.Eat("Rainbows");
            Console.WriteLine("");

            VirtualPet LennyTheLion = new VirtualPet("Lenny", 19, "Lion", false, 120);

            Console.WriteLine(">PET4");
            LennyTheLion.Greet();
            LennyTheLion.Sleep();
            LennyTheLion.Eat("Everybody!");

            Console.WriteLine("");
            VirtualPet BarisThePharris = new VirtualPet("Baris", 22, "Pharris", true, 11);
            Console.WriteLine(">PET5");
            BarisThePharris.Greet();
            BarisThePharris.Sleep();
            BarisThePharris.Poop();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}



