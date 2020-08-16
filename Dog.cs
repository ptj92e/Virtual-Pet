using System;

namespace Virtual_Pet {
    class Dog : Pet {
        // New constructor for the Dog class
        public Dog(string petName) {
            this.Name = petName;
            this.Hunger = 50;
            this.Thirst = 50;
            this.Boredom = 50;
            this.Sleepiness = 50;
        }
        // Method to play fetch
        public void fetch() {
            this.Boredom = 100;
            this.Hunger -= 20;
            this.Thirst -= 20;
            this.Sleepiness -= 40;
        }
    }
}