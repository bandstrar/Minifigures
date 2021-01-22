using System;
using System.Collections.Generic;
using System.Text;

namespace Minifigures.Minifigures
{
    class Aquanaut
    {
    
        //Properties
        public string Hat { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        //Methods
        public void Jump()
        {
            Console.WriteLine("Aquanaut jumps");
        }
        public void DoubleJump()
        {
            Console.WriteLine("Aquanaut jumps again in the air somehow");
        }
        public void Attack(bool hitBox)
        {
            if (hitBox)
            {
                Console.WriteLine("Aquanaut's punch lands. Whammo!");
            }
            else
            {
                Console.WriteLine("Aquanaut punches the air.");
            }
        }
        public void SpecialAttack(bool coolDown)
        {
            if (coolDown)
            {
                Console.WriteLine("That attack isn't ready yet.");
            }
            else
            {
                Console.WriteLine("Aquanaut fires their harpoon!");
            }
        }
        public void Look()
        {
            Console.WriteLine("Aquanaut looks around");
        }

        public void Move()
        {
            if (Accessories == "Jetpack")
            {
                Console.WriteLine("Aquanaut flies through the air.");
            }
            else
            {
                Console.WriteLine("Aquanaut runs forward.");
            }
        }
    }
}
