using Tyuiu.DolgovIV.Sprint4.Task4.V28.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] resarr =
            {
                { 3, 3, 1, 1, 4},
                { 2, 4, 2, 1, 5},
                { 2, 2, 2, 2, 2},
                { 1, 5, 4, 5, 4},
                { 1, 2, 3, 2, 4}
            };

            int[,] arr =
            {
                { 3, 3, 1, 1, 1},
                { 1, 1, 1, 1, 5},
                { 1, 1, 1, 1, 1},
                { 1, 5, 1, 5, 1},
                { 1, 1, 3, 1, 1}
            };

            CollectionAssert.AreEqual(ds.Calculate(resarr), arr);
        }
    }
}
