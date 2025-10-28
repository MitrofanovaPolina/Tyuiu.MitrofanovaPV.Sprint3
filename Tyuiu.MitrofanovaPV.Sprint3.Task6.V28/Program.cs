using Tyuiu.MitrofanovaPV.Sprint3.Task6.V28.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = 13;
        int stopValue = 19;

        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();
    }
}

