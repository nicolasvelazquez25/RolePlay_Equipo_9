using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte de Agustina Benia
            Dagger dagger = new Dagger("Dagger", 88, 34);
            IronNails ironNails = new IronNails("Iron Nails", 34, 78);
            Witch witch1 = new Witch("Manon",100, dagger, ironNails);
            Witch witch2 = new Witch("Asterin", 100, dagger, ironNails);
            Console.WriteLine(witch1.MessageCharacter());
            Console.WriteLine(witch2.MessageCharacter());
            Console.WriteLine(witch2.MessageHealth());
            witch1.MakeDmg(witch2);
            Console.WriteLine(witch2.MessageHealth());
            witch2.RestoreHealth();
            Console.WriteLine(witch2.MessageHealth());
        }
    }
}
