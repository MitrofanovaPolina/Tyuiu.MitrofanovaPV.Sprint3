using Tyuiu.MitrofanovaPV.Sprint3.Task2.V3.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task2.V3.Test
{
    [TestClass]
    public sealed class DataSErviceTest
    {
        [TestMethod]
        public void GetValidSumSeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 1;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(wait, res);
            
        }
    }
}
