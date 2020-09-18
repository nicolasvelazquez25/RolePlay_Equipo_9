using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {
        
        private Spell crucio;
        private Spellbook libro_hechizo;
        private WizardStick palo;
        private Wizard merlin;
        private Wizard voldemort;

        [SetUp]      
        public void SetUp()
        {
            Spell crucio = new Spell("Crucio", 50, 20);
            Spellbook libro_hechizo = new Spellbook("Libro hechizos", crucio);
            WizardStick palo = new WizardStick("Palo magico", 20, 0);
            Wizard merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            Wizard voldemort = new Wizard("Voldemort", 100, libro_hechizo, palo);
        } 
        
        [Test]
        /* Esta prueba se hace con el objetivo de verificar si el ataque producio sobre otro personaje es correcto, 
        usando AreEqual, siendo 30 la vida restante en caso de que el codigo este correcto*/
        public void CorrectDmg()
        {
            crucio = new Spell("Crucio", 50, 20);
            libro_hechizo = new Spellbook("Libro hechizos", crucio);
            palo = new WizardStick("Palo magico", 20, 0);
            merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            voldemort = new Wizard("Voldemort", 100, libro_hechizo, palo);
            int vida_incial = voldemort.Health;
            merlin.MakeDmg(voldemort);
            /* La vida de voldemort se ve reducida, por lo que la vida resultante sera 31*/
            Assert.AreEqual(31, voldemort.Health);
        }

        [Test]
        /* Esta prueba se hace con el objetivo de verificar la curacion de un personaje es correcta, 
        usando AreEqual, siendo 100 la vida inicial*/
        public void CorrectHeal()
        {
            crucio = new Spell("Crucio", 50, 20);
            libro_hechizo = new Spellbook("Libro hechizos", crucio);
            palo = new WizardStick("Palo magico", 20, 0);
            merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            voldemort = new Wizard("Voldemort", 100, libro_hechizo, palo);
            merlin.MakeDmg(voldemort);
            /* La vida de voldemort se ve reducida en 50*/
            voldemort.RestoreHealth();
            Assert.AreEqual(100, voldemort.Health);
        }

        [Test]
        /* En esta prueba se busca que este correcto el calculo que se hace de la suma de los daños de los objetos del personaje,
        usando nuevamente AreEqual para realizar la prueba*/
        public void CorrectGetTotalDmg()
        {
            crucio = new Spell("Crucio", 50, 20);
            libro_hechizo = new Spellbook("Libro hechizos", crucio);
            palo = new WizardStick("Palo magico", 20, 0);
            merlin = new Wizard("Merlin", 100, libro_hechizo, palo);
            /* El daño de merlin es igual a la suma del daño del libro de hechizos y el stick*/
            Assert.AreEqual(merlin.ObjectBook.Dmg + merlin.ObjectStick.Dmg, merlin.GetTotalDmg());
        }

        [Test]
        /* En esta prueba se busca que este correcto el calculo que se hace de la suma de las defensas de los objetos del personaje,
        usando nuevamente AreEqual para realizar la prueba*/
        public void CorrectGetTotalDefense()
        {
            /* la defensa de merlin es igual a la suma de de la defensa del libro de hechizos y el stick*/
            Assert.AreEqual(merlin.ObjectBook.Spell.Armor + merlin.ObjectStick.Armor, merlin.GetTotalArmor());
        }

        [Test]
        /* Utilizamos esta prueba para corroborar que se sustituya de manera correcta un libro con otro ya establecido*/
        public void CorrectGetBook()
        {
            Spell imperio = new Spell("Imperio", 70, 25);
            Spellbook libro_hechizo_prueba = new Spellbook("Libro hechizos pruebas", imperio);
            voldemort.GetBook(libro_hechizo_prueba);
            Assert.AreEqual(libro_hechizo_prueba, voldemort.ObjectBook);
        }

        [Test]
        /* En este caso utilizamos el IsNull para ver si efectivamente se elimino el libro*/
        public void CorrectOutBook()
        {
            voldemort.OutBook();
            Assert.IsNull(voldemort.ObjectBook);
        }

        [Test]
        /* Utilizamos esta prueba para corroborar que se sustituya de manera correcta un palo con otro ya establecido*/
        public void CorrectGetStick()
        {
            WizardStick palo_pruebas = new WizardStick("Palo magico pruebas", 50, 5);
            voldemort.GetStick(palo_pruebas);
            Assert.AreEqual(palo_pruebas, voldemort.ObjectStick);
        }

        [Test]
        /* En este caso utilizamos el IsNull para ver si efectivamente se elimino el palo*/
        public void CorrectOutStick()
        {
            voldemort.OutStick();
            Assert.IsNull(voldemort.ObjectStick);
        }
    }
}