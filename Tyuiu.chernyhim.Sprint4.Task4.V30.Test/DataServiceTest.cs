using Tyuiu.chernyhim.Sprint4.Task4.V30.Lib;
namespace Tyuiu.chernyhim.Sprint4.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,]
            {
                {3, 4, 0},
                {4, 0, 6},
                {7, 6, 5}
            };
            int[,] wait = new int[,]
            {
                {0, 4, 0},
                {4, 0, 6},
                {0, 6, 0}
            };
            int[,] result = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
