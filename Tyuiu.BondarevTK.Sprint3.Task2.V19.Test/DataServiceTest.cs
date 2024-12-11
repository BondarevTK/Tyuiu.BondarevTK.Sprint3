using Tyuiu.BondarevTK.Sprint3.Task2.V19.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 10;
            Assert.AreEqual(ds.GetSumSeries(x, y), -0.709);
        }
    }
}