using Tyuiu.chernyhim.Sprint4.Task0.V13.Lib;
namespace Tyuiu.chernyhim.Sprint4.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[10] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int wait = 26;
            Assert.AreEqual(wait, ds.GetSumEvenArrEl(array));
        }
    }
}
