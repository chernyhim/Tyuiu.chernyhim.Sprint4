using Tyuiu.chernyhim.Sprint4.Task7.V24.Lib;
namespace Tyuiu.chernyhim.Sprint4.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "123456789123456";
            int col = 3;
            int ray = 5;
            int wait = 2*4*6*8*2*4*6;
            Assert.AreEqual(wait, ds.Calculate(ray, col, str));
        }
    }
}
