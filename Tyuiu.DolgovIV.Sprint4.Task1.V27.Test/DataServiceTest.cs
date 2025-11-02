using Tyuiu.DolgovIV.Sprint4.Task1.V27.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] arr = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };
            Assert.AreEqual(ds.Calculate(arr), 256);
        }
    }
}
