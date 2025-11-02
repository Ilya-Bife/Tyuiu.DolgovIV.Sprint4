using Tyuiu.DolgovIV.Sprint4.Task5.V25.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] arr =
            {
                { -3, -3, -1, -1, -1},
                { -1, -1, -1, -1, -5},
                { -1, -1, -1, -1, -1},
                { -1, -5, -1, -5, -1},
                { -1, -1, -3, 1, 1}
            };

            Assert.AreEqual(ds.Calculate(arr), 2);
        }
    }
}
