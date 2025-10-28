using Tyuiu.MitrofanovaPV.Sprint3.Task4.V10.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}
