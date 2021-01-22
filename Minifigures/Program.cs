using System;
using Minifigures.Minifigures;

namespace Minifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var aquanaut1 = new Aquanaut
            {
                Hat = "Diving Helmet",
                Head = "Goggles",
                Torso = "Underwater Armor",
                Legs = "Underwater Armor",
                Accessories = "Jetpack"
            };
            aquanaut1.SpecialAttack(true);
        }
        
    }
}
