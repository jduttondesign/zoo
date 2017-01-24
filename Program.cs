using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Squeek, Squeek!");
            
            var JennifersAnimals = new Animal();
            JennifersAnimals.Name = "Black";
            JennifersAnimals.Color = "Cat";
            JennifersAnimals.Length = "Large";

            Console.WriteLine(JennifersAnimals.Color);
            
            Wolf NewWolfInstance = new Wolf();
            Console.WriteLine(NewWolfInstance.Name);
            Console.WriteLine(NewWolfInstance.Color);
            Console.WriteLine(NewWolfInstance.Length);

            // Felis NewFelis = new Felis("a", "b", "c");
            // Console.WriteLine(NewFelis.Name);
            // Console.WriteLine(NewFelis.Color);
            // Console.WriteLine(NewFelis.Length);

            // Talpa NewTalpa = new Talpa("j","k","l");
            // Console.WriteLine(NewTalpa.Name);
            // Console.WriteLine(NewTalpa.Color);
            // Console.WriteLine(NewTalpa.Length);
            
              
        }
    }
}

