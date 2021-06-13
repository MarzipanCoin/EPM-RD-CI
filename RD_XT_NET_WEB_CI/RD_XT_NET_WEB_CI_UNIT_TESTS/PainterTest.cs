using Microsoft.VisualStudio.TestTools.UnitTesting;
using RD_XT_NET_WEB_CI.Classes;
using System;
using System.Linq;
using System.Reflection;

namespace RD_XT_NET_WEB_CI_UNIT_TESTS
{
    [TestClass]
    public class PainterTest
    {
        IPainter _painter;

        [TestMethod]
        public void GetSquareCorrectTest()
        {
            Initialize();
            // Arrange: Elems was prepared for test. We get 12 and 8, and create Calculater as ICalculator<int>
            var expectedResult = "*****\n*   *\n*   *\n*   *\n*****\n";

            //// Act: The method of Calculater was executed.
            var actualResult = _painter.GetSquare(5);

            //// Assert: We're awaiting then 12 + 8 will equal Calculator.Summ
            Assert.AreEqual(expectedResult, actualResult);
        }

        private void Initialize()
        {
            if (_painter == null)
            {
                _painter = Assembly.GetAssembly(
                typeof(IPainter))
                .GetTypes()
                .Where(t => t.GetInterfaces()
                .Contains(typeof(IPainter)))
                .Select(t => Activator.CreateInstance(t) as IPainter)
                .FirstOrDefault();
            }
        }
    }
}
