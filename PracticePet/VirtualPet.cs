using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePet
{
    internal class VirtualPet
    {
        public string FullName;
        public int Age;
        public string Species;
        public bool IsAwake;
        private int ExperiencePoints;

        public VirtualPet(string petname, int petage, string petspecies, bool petisawake, int xp)
        {
            this.Species = petspecies;
            this.Age = petage;
            this.FullName = petname;
            this.IsAwake = petisawake;
            this.ExperiencePoints = xp;
        }


        public void Greet()
        {

            Console.WriteLine($"My name is {FullName}.");
            Console.WriteLine($"I am {Age} , and i am a {Species}");
            Console.WriteLine($"Am i awake?,{IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;
            Console.WriteLine($"{ FullName} is now happily asleep");
        }

        public void Eat(string FoodName)
        {
            Console.WriteLine($"{FullName} is now eating some {FoodName}");
        }

        public void Poop()
        {
            Console.WriteLine($"{FullName} is now taking a poop!");
        }


    }
}
