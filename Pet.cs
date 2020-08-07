using System;
using Sharprompt;

namespace Virtual_Pet {
    public class Pet 
    {
        public static void Hello()
        {
            var petType = Prompt.Select("What kind of pet am I?", new[] {"Dog", "Cat"});
            Console.WriteLine(petType);
        }
    }
}