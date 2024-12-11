using Tyuiu.BondarevTK.Sprint3.Task3.V1.Lib;
namespace Tyuiu.BondarevTK.Sprint3.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'a';
            Console.WriteLine(ds.GetCharCount(value, item));
        }
    }
}
