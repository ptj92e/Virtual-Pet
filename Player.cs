using System;

namespace Virtual_Pet {
    public class Player {
        // Creating a new property Name to keep track of the player's name
        public string Name { get; private set; }
        // Establishing a constructor to create new players
        public Player(string name) {
            this.Name = name;
        }
    }
}