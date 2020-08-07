using System;
using Sharprompt;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Prompt.Input<string>("What is your name?");
            Console.WriteLine(name);
            Console.WriteLine("Hello World!");
            Game.Init();
            Player.Greet();
            Pet.Hello();
        }
    }
}
