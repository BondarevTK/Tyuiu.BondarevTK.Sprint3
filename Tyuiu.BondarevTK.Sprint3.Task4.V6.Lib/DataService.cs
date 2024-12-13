using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BondarevTK.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double sum = 0;
            for (x = startValue; x<= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                sum = sum + (x/(Math.Cos(x) - Math.Sin(x)));

            }
            return Math.Round(sum,3);
        }
    }
}
