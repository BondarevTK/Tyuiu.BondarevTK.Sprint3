using Tyuiu.BondarevTK.Sprint3.Task6.V11.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 19;
            Assert.AreEqual(ds.GetSumTheDivisors(x, y), 9);
        }
    }
}