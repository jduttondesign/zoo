using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Batfish: Animal
    {
        public Batfish(string Color, string Species, string Size)
        {
            this.Color = "Blue";
            this.Species = "Fish";
            this.Size = "Tiny";
        }
        public Batfish()
        {
            this.Color = "Lavendar";
            this.Species = "One";
            this.Size = "Giant";
        }
          public Batfish()
        {
            this.Color = "Aqua";
            this.Species = "Two";
            this.Size = "Smallish";
        }
          public Batfish()
        {
            this.Color = "Rouge";
            this.Species = "Three";
            this.Size = "VeryTiny";
        }
        //three overloaded and one overide 
    }   
}






