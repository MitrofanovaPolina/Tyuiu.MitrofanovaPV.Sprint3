using Tyuiu.MitrofanovaPV.Sprint3.Task2.V3.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();
        int value = 1;
        int startValue = 1;
        int stopValue = 1;
        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 1;
        Assert.AreEqual(res, wait);
    }
}
