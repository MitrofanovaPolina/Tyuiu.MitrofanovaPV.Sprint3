using Tyuiu.MitrofanovaPV.Sprint3.Task3.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        string value = "f3g5ht g4j 34kg4";
        char item = 'e';
        
        Console.WriteLine(ds.ReplaceNumOnChar(value, item));
        Console.ReadKey();
    }
}
