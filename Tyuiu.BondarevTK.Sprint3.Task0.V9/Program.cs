using Tyuiu.BondarevTK.Sprint3.Task0.V9.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int endValue = 15;
            Console.WriteLine(ds.GetSumSeries(value, startValue, endValue));
        }
    }
}
