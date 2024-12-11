using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BondarevTK.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            int i = startValue;
            double sum = 0;
            while (i < stopValue)
            {
                sum = sum + Math.Pow(value,i) + 1/2;
                i++;
            }
            return Math.Round(sum, 2);
        }
    }
}
