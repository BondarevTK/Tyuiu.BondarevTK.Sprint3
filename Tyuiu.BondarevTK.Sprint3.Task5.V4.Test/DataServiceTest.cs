using Tyuiu.BondarevTK.Sprint3.Task5.V4.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 3;
            int z = 1;
            int v = 13;
            int f = 5;
            Assert.AreEqual(ds.GetSumSumSeries(f, x, y, z, v), 3328.185);
        }
    }
}