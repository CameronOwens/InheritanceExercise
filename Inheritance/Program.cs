using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var flyBird = new Bird();
            flyBird.Color = "black";
            flyBird.CanFly = true;
            flyBird.DoMigrate = true;
            flyBird.BeakLength = 5;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var iguana = new Reptile();
            iguana.HasScales = true;
            iguana.HasVenom = false;
            iguana.Habitat = "Marsh";
            iguana.IsColdBlooded = true;

            var myAnimals = new Animal[] { flyBird, iguana };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"Has {animal.LegCount} legs");
                Console.WriteLine($"Likes to travel by {animal.LandSeaAir}");
            }
        }
    }
}
