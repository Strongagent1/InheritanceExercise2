using System;
using System.Reflection;
using System.Xml;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-DONE
            // give this class 4 members that all Animals have in common-DONE


            // Create a class Bird-DONE
            // give this class 4 members that are specific to Bird-DONE
            // Set this class to inherit from your Animal Class-DONE

            // Create a class Reptile-DONE
            // give this class 4 members that are specific to Reptile-DONE
            // Set this class to inherit from your Animal Class-DONE




            /*Create an object of your Bird class-DONE
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values -DONE
             */
            var firstBird = new Bird();
            firstBird.BirdName = "Cardinal";
            firstBird.CanFly = true;
            firstBird.BirdPrimaryColor = "Red";
            firstBird.HasFeathers = true;
            firstBird.IsEndangered = false;
            firstBird.LivesInAquaticArea = false;
            firstBird.NumberOfEyes = 2;
            firstBird.NumberOfLegs= 2;

            Console.WriteLine($"This bird is called a {firstBird.BirdName}. It has {firstBird.NumberOfEyes} eyes, and {firstBird.NumberOfLegs} legs. It's {firstBird.HasFeathers}, the {firstBird.BirdName} has feathers." +
                $"The {firstBird.BirdName} typically is also {firstBird.BirdPrimaryColor}, making it easier to identify. If you live in Ohio, it's {firstBird.CanFly}, you may see them flying in your yard!");

            Console.WriteLine("------------------------------------------------------------------");

            /*Create an object of your Reptile class-DONE
             *  give values to your members using the object of your Reptile class-DONE
             *  
             * Creatively display the class member values-DONE 
             */
            var firstReptile = new Reptile()
            {
                IsEndangered = true,
                LivesInAquaticArea = true,
                NumberOfEyes = 2,
                NumberOfLegs = 2,
                ReptileName = "Gecko",
                ReptileColor = "green",
                EatsInsects= true,
                HasScales = true,
            };            
            //firstReptile.IsEndangered= false;
            //firstReptile.LivesInAquaticArea = false;
            //firstReptile.NumberOfEyes = 2;
            //firstReptile.NumberOfLegs= 4;
            //firstReptile.ReptileName = "Gecko";
            //firstReptile.HasScales = true;
            //firstReptile.ReptileColor = "green";
            //firstReptile.EatsInsects = true;

            Console.WriteLine($"This reptile is called a {firstReptile.ReptileName}. It has {firstReptile.NumberOfEyes} eyes, and {firstReptile.NumberOfLegs} legs. It's {firstReptile.HasScales}, the {firstReptile.ReptileName} does have scales." +
                $"The {firstReptile.ReptileName} typically is also {firstReptile.ReptileColor}, making it easier to identify. {firstReptile.ReptileName}s will not typically hang out around water, that is a common misconception, but it is {firstReptile.LivesInAquaticArea}.");
           
        }
    }
}
