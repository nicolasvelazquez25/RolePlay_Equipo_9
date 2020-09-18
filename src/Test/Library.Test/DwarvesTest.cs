using System;
using NUnit.Framework;
using Library;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
namespace Test.Library
{
    public class DwarvesTest
    {
<<<<<<< Updated upstream
        public void Setup(){

        }

        [Test]
        public void validateHealth()
        {
            //Testea que los valores de vida se asignen correctamente 
            Hammer h = new Hammer("El Gran martillo",15,4);
            MagicRing m =  new MagicRing("La alianza magica",12,6);

            Dwarves d = new Dwarves("Peter",15, h, m );
            Assert.AreEqual( d.BaseHealth, d.Health );
        }

        
         [Test]
        public void validateArmor(){
           //Testea que la armadura del personaje corresponda a la suma del  daños de los items 
            Hammer h = new Hammer("El Gran martillo",15,4);
            MagicRing m =  new MagicRing("La alianza magica",12,6);
            Dwarves d = new Dwarves("Peter",15, h, m );
            Assert.AreEqual( h.Armor + m.Armor, d.GetTotalArmor() );
        }
        
        [Test]
        public void validateDmg(){
            //Testea que el daño del personaje corresponda a la suma del  daños de los items 
            Hammer h = new Hammer("El Gran martillo",15,4);
            MagicRing m =  new MagicRing("La alianza magica",12,6);
            Dwarves d = new Dwarves("Peter",15, h, m );
            Assert.AreEqual( h.Dmg + m.Dmg, d.GetTotalDmg() );
        }

         [Test]
        public void validateHealthRestore(){
            //Testea que la restauracion recupere la vida base completa
            Hammer h = new Hammer("El Gran martillo",15,4);
            MagicRing m =  new MagicRing("La alianza magica",12,6);
            Dwarves d = new Dwarves("Peter",15, h, m );
            int BaseHealth = d.BaseHealth;
            d.makeDmg(12);
            d.restore();
            Assert.AreEqual( d.Health, BaseHealth);
        }
    }
=======
        private Hammer object1;
        private MagicRing object2;
        private Dwarves dummy1;
        private Dwarves dummy2;
        
        [SetUp]
        public void Setup()
        {
            object1 = new Hammer("Object1", 20, 10);
            object2 = new MagicRing("Object2", 10, 5);
            dummy1 = new Dwarves("Dummy", 100, object1, object2);
            dummy2 = new Dwarves("Dummy2", 100, object1, object2); 
        }

        [Test]
        public void CorrectTotalDamage()
        {
            Assert.AreEqual(30, dummy1.GetTotalDmg());
        }

        [Test]
        public void CorrectTotalArmor()
        {
            Assert.AreEqual(15, dummy1.GetTotalArmor());
        }
>>>>>>> Stashed changes

        [Test]
        public void CorrectDamageTaken()
        {
            dummy2.MakeDmg(dummy1);
            Assert.AreEqual(70, dummy1.Health);
        }

        [Test]
        public void CorrectHealthRestore()
        {
            dummy2.MakeDmg(dummy1);
            dummy1.RestoreHealth();
            Assert.AreEqual(100, dummy1.Health);
        }
    }
}