using System;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startGame = Game.newGame();
            // If the startGame variable is true, the program runs the newPlayer method.
            if (startGame == true) {
                Console.Clear();
                Game.newPlayer();
            // If the startGame variable is false, the program closes out with a message to the user. 
            } else {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}
