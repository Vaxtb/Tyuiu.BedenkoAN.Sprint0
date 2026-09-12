using Tyuiu.BedenkoAN.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BedenkoAN.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekedAdditionArrayValiud()


        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);



        }

        [TestMethod]
        public void ChekedSubstractinArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, };

            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);


        }
        [TestMethod]
        public void CheckedMultiplicationArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}