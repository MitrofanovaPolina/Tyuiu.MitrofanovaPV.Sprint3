using Tyuiu.MitrofanovaPV.Sprint3.Task4.V10.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine(ds.Calculate(startValue, stopValue));
        Console.ReadKey();
    }
}
