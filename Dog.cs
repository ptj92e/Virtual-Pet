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
    }
}