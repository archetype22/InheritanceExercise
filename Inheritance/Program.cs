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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Bird bird1= new Bird();
            bird1.Species = "Andean Condor";
            bird1.BeakShape = "curved";
            bird1.Diet = "seal and whale carcasses";
            bird1.Wingspan= 10;

            Console.WriteLine($"The {bird1.Species} is the largest raptor in the world, having a wingspan of {bird1.Wingspan} feet!");
            Console.WriteLine($"{bird1.Species}s have {bird1.BeakShape} beaks, which aids them in their diet of {bird1.Diet}." );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine();


            Reptile reptile1= new Reptile();
            reptile1.Species = "Komodo Dragon";
            reptile1.Texture = "hardened scales";
            reptile1.DoesHibernate = false;
            reptile1.Diet = "carnivore";

            Console.WriteLine($"The {reptile1.Species} is the largest lizard on earth! It is a {reptile1.Diet} with {reptile1.Texture}. \n" +
                $"It lives on a temperate island. It is also a cold-blooded reptile. You would expect them to hibernate but  \n" +
                $"due to these conditions, that assumption would be '{reptile1.DoesHibernate}.'");


        }
    }
}
