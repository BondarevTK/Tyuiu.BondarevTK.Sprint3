using Tyuiu.BondarevTK.Sprint3.Task3.V1.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'a';
            Assert.AreEqual(ds.GetCharCount(value, item), 2);
        }
    }
}