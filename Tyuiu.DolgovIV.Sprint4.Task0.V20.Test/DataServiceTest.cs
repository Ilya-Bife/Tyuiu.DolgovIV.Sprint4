using System.Reflection;
using Tyuiu.DolgovIV.Sprint4.Task0.V20.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Assert.AreEqual(24576, ds.GetMultEvenArrEl(array));
        }
    }
}
