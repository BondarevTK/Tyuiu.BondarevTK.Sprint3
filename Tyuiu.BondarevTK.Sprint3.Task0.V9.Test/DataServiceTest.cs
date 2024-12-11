using System.Security.Cryptography.X509Certificates;
using Tyuiu.BondarevTK.Sprint3.Task0.V9.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            int y = 1;
            int z = 15;
            double res = ds.GetSumSeries(x, y, z);
            Assert.AreEqual(res, 0.43);
        }
    }
}