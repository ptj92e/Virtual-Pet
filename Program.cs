using System;
using Sharprompt;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Prompt.Input<string>("What is your name?");
            Player player = new Player(name);
            Console.WriteLine(player.Name);
        }
    }
}
