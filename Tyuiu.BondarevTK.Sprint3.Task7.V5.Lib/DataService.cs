using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BondarevTK.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 1.2 == 0)
                {
                    
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                valueArray[count] = Math.Round((2 * Math.Sin(x) / 3 * x + 1.2) + Math.Cos(x) - 7 * x - 2,2);
                count++;
            }
            return valueArray;
        }
    }
}
