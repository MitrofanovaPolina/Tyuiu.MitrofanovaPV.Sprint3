using Tyuiu.MitrofanovaPV.Sprint3.Task7.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("+-------------+-------------+");
        Console.WriteLine("|     x       |      f(x)    ");
        Console.WriteLine("+-------------+-------------+");
        for (int i = 0;  i <= len-1; i++)
        {
            Console.WriteLine("| {0,5:}  |   {1,5:f2}    |", startValue, valueArray[i]);
        }
        Console.ReadKey();
    }
}