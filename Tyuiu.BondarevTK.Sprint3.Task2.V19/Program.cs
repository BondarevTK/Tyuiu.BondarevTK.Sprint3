using Tyuiu.BondarevTK.Sprint3.Task2.V19.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 10;
            Console.WriteLine(ds.GetSumSeries(x, y));
        }
    }
}
