using Tyuiu.MitrofanovaPV.Sprint3.Task2.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int value = 4;
        int startValue = 1;
        int stopValue =15;
        Console.WriteLine("Сумма ряда =" + ds.GetSumSeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}