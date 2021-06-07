using Microsoft.VisualStudio.TestTools.UnitTesting;
using RD_XT_NET_WEB_CI.Classes;

namespace RD_XT_NET_WEB_CI_UNIT_TESTS
{
    [TestClass]
    public class CalculaterTests
    {
        [TestMethod]
        public void SummCorrectTest()
        {
            // Arrange: Elems was prepared for test. We get 12 and 8, and create Calculater as ICalculator<int>
            ICalculater<int> intCalculater = new Calculater();
            var firstElem = 12;
            var secondElem = 8;

            // Act: The method of Calculater was executed.
            var actualResult = intCalculater.Summ(firstElem, secondElem);

            // Assert: We're awaiting then 12 + 8 will equal Calculator.Summ
            Assert.AreEqual(12 + 8, actualResult);
        }

        [TestMethod]
        public void DifCorrectTest()
        {
            // Arrange: Elems was prepared for test. We get 12 and 8, and create Calculater as ICalculator<int>
            ICalculater<int> intCalculater = new Calculater();
            var firstElem = 12;
            var secondElem = 8;

            // Act: The method of Calculater was executed.
            var actualResult = intCalculater.Difference(firstElem, secondElem);

            // Assert: We're awaiting then 12 + 8 will equal Calculator.Summ
            Assert.AreEqual(12 - 8, actualResult);
        }
    }
}
