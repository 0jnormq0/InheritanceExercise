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

            Bird birdOne = new Bird();
            birdOne.Name = "Cardinal";
            birdOne.Legs = 2;
            birdOne.Beak_Color = "Orange";
            birdOne.Sex = "Male";
            birdOne.Feather_Colors = "Red";
            birdOne.Wingspan = "30.5 cm";

            Console.WriteLine($"Animal:....... {birdOne.Name} ");
            Console.WriteLine($"Sex:.......... {birdOne.Sex}");
            Console.WriteLine($"Color:........ {birdOne.Feather_Colors}");
            Console.WriteLine($"Legs:......... {birdOne.Legs}");
            Console.WriteLine($"Beak:......... {birdOne.Beak_Color}");
            Console.WriteLine($"Wingspan:..... {birdOne.Wingspan}");
            Console.WriteLine($"");

            Reptile reptileOne = new Reptile();
            reptileOne.Name = "Common House Gecko";
            reptileOne.Legs = 4;
            reptileOne.Egg_Fertilization = "Internally";
            reptileOne.Scales = "Gray, light brown, or beige";
            reptileOne.Teeth = 100;
            reptileOne.Length = "7.5 cm";

            Console.WriteLine($"Animal:....... {reptileOne.Name}");
            Console.WriteLine($"Scales:....... {reptileOne.Scales}");
            Console.WriteLine($"Fertilize:.... {reptileOne.Egg_Fertilization}");
            Console.WriteLine($"Legs:......... {reptileOne.Legs}");
            Console.WriteLine($"Teeth:........ {reptileOne.Teeth}");
            Console.WriteLine($"Length:....... {reptileOne.Length}");

        }
    }
}
