using Tyuiu.chernyhim.Sprint4.Task3.V30.Lib;
namespace Tyuiu.chernyhim.Sprint4.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
            {
                {1,2,3,4,5 },
                {5,4,3,2,1 },
                {7,8,9,6,5 },
                {0,0,0,0,0 },
                {1,2,3,4,5 }
            };
            int result = ds.Calculate(array);
            Assert.AreEqual(9, result);
        }
    }
}
