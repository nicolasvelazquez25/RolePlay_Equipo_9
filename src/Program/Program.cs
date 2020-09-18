using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ShieldElve shield = new ShieldElve("Shield", 100, 200);
            SwordElve sword = new SwordElve("Sword", 100, 200);
            Elves Elves=new Elves("Elve",100, shield, sword);
            Console.WriteLine("Elve name:"+ Elves.Name);
            Console.WriteLine("Shield Armor: "+ shield.Armor);
            Elves Elves2=new Elves("Elve2",120, shield, sword);
            Console.WriteLine(Elves2.MessageCharacter());
            Console.WriteLine(Elves.MessageCharacter());
            Console.WriteLine(Elves2.MessageHealth());
            Elves.MakeDmg(Elves2);  
            Console.WriteLine(Elves2.MessageHealth());
            Elves2.RestoreHealth();
            Console.WriteLine(Elves2.MessageHealth());
        }
    }
}
