using Tyuiu.DolgovIV.Sprint4.Task3.V3.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] arr =
            {
                { 9, 4, 5, 4, 8},
                { 7, 6, 7, 7, 4,},
                { 4, 4, 3, 5, 6,},
                { 6, 5, 9, 4, 9,},
                { 9, 7, 8, 7, 7}
            };

            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(arr), 14);
        }
    }
}
