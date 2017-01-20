using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quack, Quack!");
            
            var JennifersAnimals = new Animal();
            JennifersAnimals.Color = "Black";
            JennifersAnimals.Species = "Cat";
            JennifersAnimals.Size = "Large";

            Console.WriteLine(JennifersAnimals.Color);
            
            Panda NewPanda = new Panda("p", "k", "z");
            Console.WriteLine(NewPanda.Color);
            Console.WriteLine(NewPanda.Species);
            Console.WriteLine(NewPanda.Size);

            Fossa NewFossa = new Fossa("a", "b", "c");
            Console.WriteLine(NewFossa.Color);
            Console.WriteLine(NewFossa.Species);
            Console.WriteLine(NewFossa.Size);

            Batfish NewBatfish = new Batfish("j","k","l");
            Console.WriteLine(NewBatfish.Color);
            Console.WriteLine(NewBatfish.Species);
            Console.WriteLine(NewBatfish.Size);
            
              
        }
    }
}

