using CalidadT1;

namespace TestCalidadT1BookStore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BookStore bk = new BookStore();
            //---------------------
            Book lib1 = new Book();
            lib1.Name = "Libro 1";
            lib1.Price = 10;
            Book lib2 = new Book();
            lib2.Name = "Libro 2";
            lib2.Price = 15;
            //---------------------
            bk.AddToCart(lib1);
            bk.AddToCart(lib2);
            //---------------------
            Assert.AreEqual(25, bk.GetTotal());
        }
        [TestMethod]
        public void TestMethod2()
        {
            BookStore bk = new BookStore();
            //---------------------
            Book lib1 = new Book();
            lib1.Name = "Libro 1";
            lib1.Price = 10;
            Book lib2 = new Book();
            lib2.Name = "Libro 2";
            lib2.Price = 10;
            //---------------------
            bk.AddToCart(lib1);
            bk.AddToCart(lib2);
            //---------------------
            Assert.AreEqual(20, bk.GetTotal());
        }
        [TestMethod]
        public void TestMethod3()
        {
            BookStore bk = new BookStore();
            //---------------------
            Book lib1 = new Book();
            lib1.Name = "Libro 1";
            lib1.Price = 10;
            Book lib2 = new Book();
            lib2.Name = "Libro 2";
            lib2.Price = 10;
            //---------------------
            bk.AddToCart(lib1);
            bk.AddToCart(lib1);
            //---------------------
            Assert.AreEqual(19, bk.GetTotal());
        }
    }
}