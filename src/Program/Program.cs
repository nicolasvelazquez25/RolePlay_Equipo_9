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
        }
    }
}
