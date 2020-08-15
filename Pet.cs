using System;
using Sharprompt;

namespace Virtual_Pet {
    public class Pet 
    {
        // Define properties for a general pet class
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Sleepiness { get; set; }

        // Define getters and setters for each variable in the generic pet class
        public static void Hello()
        {
            var petType = Prompt.Select("What kind of pet am I?", new[] {"Dog", "Cat"});
            Console.WriteLine(petType);
        }
    }
}