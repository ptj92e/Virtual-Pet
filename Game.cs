using System;
using Sharprompt;

namespace Virtual_Pet {
    public class Game {
        // This method starts the game
        public static bool newGame() {
            Console.WriteLine("Welcome to Virtual Pet!");
            // Prompt the user to continue the game
            var game = Prompt.Confirm("Would you like to adopt a new pet?");
            // Depending on the user's input, the method will either return true or false
            if (game == true) {
                Console.Clear();
                return true;
            } else {
                Console.Clear();
                return false;
            }
        }
        // Method to create a new Player
        public static void newPlayer() {
            // Prompt the user for their name
            var name = Prompt.Input<string>("What is your name?");
            // Error check for the name to see if it is longer than one character. If it is, then prompt the user for their name again. 
            if (name == null || name.Length < 2) {
                Console.WriteLine("Your name must be longer than 1 character.");
                Game.newPlayer();
            } else {
                // If the input is longer than 1 character, then the method creates a new Player
                Player player = new Player(name);
                Console.WriteLine(player.Name);
            }
        }
        // Method to create a new Pet

        // Method to handle User's Input
    }
}