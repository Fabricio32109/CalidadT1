using CalidadT1;
namespace TestCalidadT1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(25);
            Assert.AreEqual("XXV", n);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(-1);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod3()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(1000);
            Assert.AreEqual("M", n);
        }
        [TestMethod]
        public void TestMethod4()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(4);
            Assert.AreEqual("IV", n);
        }
        [TestMethod]
        public void TestMethod5()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(39);
            Assert.AreEqual("XXXIX", n);
        }
        [TestMethod]
        public void TestMethod6()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(30);
            Assert.AreEqual("XXX", n);
        }
        [TestMethod]
        public void TestMethod7()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(0);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod8()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(-10);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod9()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(19);
            Assert.AreEqual("XIX", n);
        }
        [TestMethod]
        public void TestMethod10()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(31);
            Assert.AreEqual("XXXI", n);
        }
        [TestMethod]
        public void TestMethod11()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(72);
            Assert.AreEqual("LXXII", n);
        }
        [TestMethod]
        public void TestMethod12()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(-1);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod13()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(1000);
            Assert.AreEqual("M", n);
        }
        [TestMethod]
        public void TestMethod14()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(4);
            Assert.AreEqual("IV", n);
        }
        [TestMethod]
        public void TestMethod15()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(39);
            Assert.AreEqual("XXXIX", n);
        }
        public void TestMethod16()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(25);
            Assert.AreEqual("XXV", n);
        }
        [TestMethod]
        public void TestMethod17()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(-1);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod18()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(1000);
            Assert.AreEqual("M", n);
        }
        [TestMethod]
        public void TestMethod19()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(4);
            Assert.AreEqual("IV", n);
        }
        [TestMethod]
        public void TestMethod20()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(39);
            Assert.AreEqual("XXXIX", n);
        }
        public void TestMethod21()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(25);
            Assert.AreEqual("XXV", n);
        }
        [TestMethod]
        public void TestMethod22()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(-1);
            Assert.AreEqual("ERROR", n);
        }
        [TestMethod]
        public void TestMethod23()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(1000);
            Assert.AreEqual("M", n);
        }
        [TestMethod]
        public void TestMethod24()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(4);
            Assert.AreEqual("IV", n);
        }
        [TestMethod]
        public void TestMethod25()
        {
            RomanoGenerator aux = new RomanoGenerator();
            string n = aux.GetRomano(39);
            Assert.AreEqual("XXXIX", n);
        }
    }
}