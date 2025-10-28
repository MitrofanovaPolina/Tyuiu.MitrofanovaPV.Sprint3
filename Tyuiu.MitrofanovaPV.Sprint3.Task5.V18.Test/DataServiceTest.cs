using Tyuiu.MitrofanovaPV.Sprint3.Task5.V18.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 1;
            int stopValue2 = 1;
            double res = ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1, stopValue2);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
