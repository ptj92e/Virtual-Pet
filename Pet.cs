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

        // Method to feed the pet
        public void feed() {
            this.Hunger = 100;
            this.Thirst -= 10;
            this.Sleepiness -= 20;
        }
        // Method to make the pet drink
        public void drink() {
            this.Thirst = 100;
        }
        // Method to make the pet sleep
        public void sleep() {
            this.Sleepiness = 100;
            this.Hunger -= 20;
            this.Thirst -= 20;
            this.Boredom -= 20;
        }
        // Method of print stats of pet
        public void printStats() {

        }
    }
}