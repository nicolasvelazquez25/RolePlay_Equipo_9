using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parte de Fabio Luzzatto
            Hammer h = new Hammer("Mjölnir", 200, 0);
            MagicRing m = new MagicRing("One ring", 0, 800);
            Dwarves dwarv1 = new Dwarves("ThorEnano",200, h, m);
            Dwarves dwarv2 = new Dwarves("ThorEnano 2", 100, h, m);
            Console.WriteLine(dwarv1.MessageCharacter());
            Console.WriteLine(dwarv2.MessageCharacter());
            Console.WriteLine(dwarv2.MessageHealth());
            dwarv1.MakeDmg(dwarv2);
            Console.WriteLine(dwarv2.MessageHealth());
            dwarv2.RestoreHealth();
            Console.WriteLine(dwarv2.MessageHealth());
        }
    }
}