using Tyuiu.BondarevTK.Sprint3.Task4.V6.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            Assert.AreEqual(ds.Calculate(x, y), 8.955);
        }
    }
}