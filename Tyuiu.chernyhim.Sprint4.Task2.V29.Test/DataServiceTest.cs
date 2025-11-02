using Tyuiu.chernyhim.Sprint4.Task2.V29.Lib;
namespace Tyuiu.chernyhim.Sprint4.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[11] { 7, 7, 5, 8, 2, 7, 3, 3, 3, 1, 2 };
            int wait = 32;
            Assert.AreEqual(wait, ds.Calculate(array));
        }
    }
}
