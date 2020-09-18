using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ElvesTest
    {
        private SwordElve object1;
        private ShieldElve object2;
        private Elves dummy1;
        private Elves dummy2;
        
        [SetUp]
        public void Setup()
        {
            object2 = new ShieldElve("Object2", 10, 5);
            object1 = new SwordElve("Object1", 20, 10);
            dummy1 = new Elves("Dummy", 100, object2, object1);
            dummy2 = new Elves("Dummy2", 100, object2, object1); 
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