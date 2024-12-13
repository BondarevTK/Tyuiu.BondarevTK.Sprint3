using Tyuiu.BondarevTK.Sprint3.Task5.V4.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int startvalue1 = 1;
            int startvalue2 = 1;
            int endvalue1 = 3;
            int endvalue2 = 13;
            Console.WriteLine(ds.GetSumSumSeries(x, startvalue1, startvalue2, endvalue1, endvalue2));
        }
    }
}
