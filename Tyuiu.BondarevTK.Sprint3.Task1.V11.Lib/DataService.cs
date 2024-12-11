using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BondarevTK.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sum = 1;
            while (startValue <= stopValue)
            {
                sum = sum * (Math.Pow(value,startValue) + 0.5);
                startValue++;
                Console.WriteLine(sum);
            }
            return Math.Round(sum,3);
        }
    }
}
