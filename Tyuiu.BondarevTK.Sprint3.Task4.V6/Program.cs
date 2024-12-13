using Tyuiu.BondarevTK.Sprint3.Task4.V6.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int endvalue = -5;
            Console.WriteLine(ds.Calculate(startvalue, endvalue));
        }
    }
}
