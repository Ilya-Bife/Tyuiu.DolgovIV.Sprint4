using Tyuiu.DolgovIV.Sprint4.Task7.V27.Lib;

namespace Tyuiu.DolgovIV.Sprint4.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string inp = "583197256891";

            Assert.AreEqual(4, ds.Calculate(4,3,inp));
        }
    }
}
