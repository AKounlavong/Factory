using System;

namespace factoryLab
{
    class Rocket
    {
        public string height { get; set; }
        public string fuel { get; set; }
        public void Print(){
            Console.WriteLine($"{height} {fuel}");
        }
    }
}