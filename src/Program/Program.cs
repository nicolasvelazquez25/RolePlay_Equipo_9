using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parte de Yonatan Morgades
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
          
            // Parte de Fabio Luzzatto
            SolarSword sword = new SolarSword("Solar Sword", 100, 0);
            SolarShield shield = new SolarShield("Solar Shield", 0, 8000);
            DefenderElf1 elf1 = new DefenderElf1("Defender Elf",100, sword, shield);
            DefenderElf1 elf2 = new DefenderElf1("Defender Elf 2", 100, sword, shield);
            Console.WriteLine(elf1.MessageCharacter());
            Console.WriteLine(elf2.MessageCharacter());
            Console.WriteLine(elf2.MessageHealth());
            elf1.MakeDmg(elf2);
            Console.WriteLine(elf2.MessageHealth());
            elf2.RestoreHealth();
            Console.WriteLine(elf2.MessageHealth());
          
            //Parte de Nicolas Velazquez
            Spell crucio = new Spell("Crucio", 50, 20);
            Spellbook libro_hechizo = new Spellbook("Libro hechizos", crucio);
            WizardStick palo = new WizardStick("Palo magico", 60, 0);
            Wizard merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            Console.WriteLine(libro_hechizo.Dmg);
        }
    }
}
