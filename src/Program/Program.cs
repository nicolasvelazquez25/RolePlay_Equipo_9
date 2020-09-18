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
            SolarSword sword = new SolarSword("Solar Sword", 100, 0);
            SolarShield shield = new SolarShield("Solar Shield", 0, 8000);
            DefenderElf1 elf1 = new DefenderElf1("Defender Elf",100, sword, shield);
            DefenderElf1 elf2 = new DefenderElf1("Defender Elf 2", 100, sword, shield);
            elf1.MakeDmg(elf2);
            Console.WriteLine(elf2.MessageHealth());
            Console.WriteLine(elf1.MessageCharacter());
        }
    }
}
