using Tyuiu.MitrofanovaPV.Sprint3.Task1.V29.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetValidMultSeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 1;
            double res = ds.GetMultiplySeries(value, startValue,stopValue);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
