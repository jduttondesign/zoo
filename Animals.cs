using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string Color {get; set;}
        public string Species {get; set;}
        public string Size {get; set;}

        public string Speak()
            {
            return "Quack!";
            }
    }
}