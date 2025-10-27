using Tyuiu.MitrofanovaPV.Sprint3.Task0.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        double value = 1.5;
        int startValue = 1;
        int stopValue = 13;
        Console.WriteLine("Сумма ряда =" + Math.Round(ds.GetSumSeries(value, startValue, stopValue),3));
        Console.ReadKey();
    }
}
    