using Tyuiu.MitrofanovaPV.Sprint3.Task3.V21.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "yftdtdy656";
            char item = 'e';
            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "gft6d6tdt6";
            Assert.AreEqual(res,wait);

        }
    }
}
