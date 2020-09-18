using NUnit.Framework;
using Library;
namespace Test.Library
{
    public class DefenderElf1Test
    {
        private SolarSword object1;
        private SolarShield object2;
        private DefenderElf1 dummy1;
        private DefenderElf1 dummy2;
        
        [SetUp]
        public void Setup()
        {
        object1 = new SolarSword("Object1", 20, 10);
        object2 = new SolarShield("Object2", 10, 5);
        dummy1 = new DefenderElf1("Dummy", 100, object1, object2);
        dummy2 = new DefenderElf1("Dummy2", 100, object1, object2); 
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