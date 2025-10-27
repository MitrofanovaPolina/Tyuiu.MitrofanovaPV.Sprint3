using Tyuiu.MitrofanovaPV.Sprint3.Task1.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        double value = 0.25;
        int startValue = 1;
        int stopValue = 11;
        Console.WriteLine("Сумма ряда =" + Math.Round(ds.GetMultiplySeries(value,startValue,stopValue), 3));
        Console.ReadKey();
    }
}