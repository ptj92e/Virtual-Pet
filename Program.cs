﻿using System;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game.Init();
            Player.Greet();
            Pet.Hello();
        }
    }
}
