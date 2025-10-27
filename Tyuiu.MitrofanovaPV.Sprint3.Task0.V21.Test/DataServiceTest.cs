using Tyuiu.MitrofanovaPV.Sprint3.Task0.V21.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 2;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
