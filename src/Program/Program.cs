using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Spell crucio = new Spell("Crucio", 50, 20);
            Spellbook libro_hechizo = new Spellbook("Libro hechizos", crucio);
            WizardStick palo = new WizardStick("Palo magico", 60, 0);
            Wizard merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            Console.WriteLine(libro_hechizo.Attack);
            
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
