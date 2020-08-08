using System;
using Sharprompt;

namespace Virtual_Pet {
    public class Pet 
    {
        // Define variables for a general pet class

        // Create a constructor

        // Define getters and setters for each variable in the generic pet class
        public static void Hello()
        {
            var petType = Prompt.Select("What kind of pet am I?", new[] {"Dog", "Cat"});
            Console.WriteLine(petType);
        }
    }
}