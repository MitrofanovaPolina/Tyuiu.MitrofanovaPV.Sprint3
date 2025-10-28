using Tyuiu.MitrofanovaPV.Sprint3.Task7.V21.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task7.V21.Test
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
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 1;
            valueWaitArray[1] = 2;
            valueWaitArray[2] = 3;
            valueWaitArray[3] = 4;
            valueWaitArray[4] = 5;
            valueWaitArray[5] = 6;
            valueWaitArray[6] = 6;
            valueWaitArray[7] = 6;
            valueWaitArray[8] = 6;
            valueWaitArray[9] = 6;
            valueWaitArray[10] = 6;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue,stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);

        }
    }
}
