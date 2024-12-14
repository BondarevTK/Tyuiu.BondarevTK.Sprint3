using Tyuiu.BondarevTK.Sprint3.Task7.V5.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] arraywait = new double[len];
            //70.14,55.21,41.05,27.96,15.48,1.0,-13.06,-28.16,-42.96,-56.77,-69.83
            arraywait[0] = 70.14;
            arraywait[1] = 55.21;
            arraywait[2] = 41.05;
            arraywait[3] = 27.96;
            arraywait[4] = 15.48;
            arraywait[5] = 1.0;
            arraywait[6] = -13.06;
            arraywait[7] = -28.16;
            arraywait[8] = -42.96;
            arraywait[9] = -56.77;
            arraywait[10] = -69.83;
            CollectionAssert.AreEqual(arraywait, ds.GetMassFunction(-5, 5));

        }
    }
}