using Tyuiu.BondarevTK.Sprint3.Task1.V11.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.75;
            int y = 1;
            int z = 14;
            Assert.AreEqual(ds.GetMultiplySeries(x, y, z), 0.005);
        }
    }
}