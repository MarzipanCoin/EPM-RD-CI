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
            // Arrange: Square with 5 stars side was prepared as expected result
            var expectedResult = "*****\n*   *\n*   *\n*   *\n*****\n";

            //// Act: Execute GetSquare
            var actualResult = _painter.GetSquare(5);
            var actualResultOnePoint = _painter.GetSquare(1);

            //// Assert: We're awaiting then results will be equals
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual("*", actualResultOnePoint);
        }

        [TestMethod]
        public void GetSquareExceptionTest()
        {
            Initialize();
            // Arrange: Error message was prepared
            var expectedResult = "Size can't be less than 1";

            // Act: Execute GetSquare with unpossible arguments
            var actualResultWithZero = _painter.GetSquare(0);
            var actuaResultWithNegative = _painter.GetSquare(-1);

            // Assert: Expected and actual results are equals
            Assert.AreEqual(expectedResult, actualResultWithZero);
            Assert.AreEqual(expectedResult, actuaResultWithNegative);
        }

        [TestMethod]
        public void GetRectangleCorrectTest()
        {
            Initialize();
            // Arrange: Prepare figure with 5 stars length and 3 star width
            var expectedResult = "***\n* *\n* *\n* *\n***\n";

            // Act: Execute GetRectangle
            var actualResult = _painter.GetRectangle(5, 3);
            var actualResultOnePoint = _painter.GetRectangle(1, 1);

            // Assert:
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual("*", actualResultOnePoint);
        }

        [TestMethod]
        public void GetRectangleExceptionTest()
        {
            Initialize();
            // Arrange:
            var expectedResult = "One or all sides can't be less than 1";

            // Act:
            var actualResultZeroZero = _painter.GetRectangle(0, 0);
            var actualResultZeroOne = _painter.GetRectangle(0, 1);
            var actualResultOneZero = _painter.GetRectangle(1, 0);
            var actualResultNegativeOne = _painter.GetRectangle(-1, 1);
            var actualResultOneNegative = _painter.GetRectangle(1, -1);
            var actualResultNegativeNegative = _painter.GetRectangle(-1, -1);

            //Assert:
            Assert.AreEqual(expectedResult, actualResultOneNegative);
            Assert.AreEqual(expectedResult, actualResultNegativeNegative);
            Assert.AreEqual(expectedResult, actualResultOneZero);
            Assert.AreEqual(expectedResult, actualResultNegativeOne);
            Assert.AreEqual(expectedResult, actualResultZeroOne);
            Assert.AreEqual(expectedResult, actualResultZeroZero);
        }

        [TestMethod]
        public void GetStandardTriangleCorrectTest()
        {
            Initialize();
            // Arrange:
            var expectedResult = "    *\n   ***\n  *****\n *******\n*********\n";

            // Act:
            var actualResult = _painter.GetStandardTriangle(5);

            // Assert:
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
