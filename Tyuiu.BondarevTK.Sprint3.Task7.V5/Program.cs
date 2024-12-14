using System.ComponentModel.DataAnnotations;
using Tyuiu.BondarevTK.Sprint3.Task7.V5.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(Convert.ToString(startValue));
                Console.WriteLine(res[i]);
                startValue++;
            }
        }
    }
}
