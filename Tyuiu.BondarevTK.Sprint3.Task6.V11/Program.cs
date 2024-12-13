using Tyuiu.BondarevTK.Sprint3.Task6.V11.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 19;
            Console.WriteLine(ds.GetSumTheDivisors(x, y));
        }
    }
}
