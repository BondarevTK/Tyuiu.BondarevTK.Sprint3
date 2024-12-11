using Tyuiu.BondarevTK.Sprint3.Task1.V11.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int endValue = 14;
            Console.WriteLine(ds.GetMultiplySeries(value, startValue, endValue));
        }
    }
}
