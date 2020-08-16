using System;

namespace Virtual_Pet {
    class Cat : Pet {
        // New constructor for the Cat class
        public Cat(string petName) {
            this.Name = petName;
            this.Hunger = 50;
            this.Thirst = 50;
            this.Boredom = 50;
            this.Sleepiness = 50;
        }
    }
}