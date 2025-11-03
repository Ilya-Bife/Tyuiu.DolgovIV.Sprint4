using Tyuiu.DolgovIV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] inp = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = { "Самолет", "Трамвай" };

            CollectionAssert.AreEqual(ds.Calculate(inp), res);
        }
    }
}
