using Tyuiu.BedenkoAN.Sprint0.Task3.V0.Lib;

namespace Tyuiu.BedenkoAN.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()

        {
            Assert.AreEqual(10, DataService.Sum(5, 5));


        }
    }
}
