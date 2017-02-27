using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHandIn2EquivalenceBoundary.Services.Tests
{
    [TestClass()]
    public class GetDaysInMonthClassTests
    {
        public GetDaysInMonthClass gdim;

        [TestInitialize]
        public void beforeTest()
        {
            gdim = new GetDaysInMonthClass();
        }


        /// <summary>
        /// EQUIVALENCE TEST CASES FOR MONTHS
        /// </summary>

        [TestMethod()]
        public void validMonthWithThirtyOneDays()
        {
            Assert.AreEqual(31, gdim.getNumberOfDaysInMonth(3, 543));
        }

        [TestMethod()]
        public void validMonthWithThirtyDays()
        {
            Assert.AreEqual(30, gdim.getNumberOfDaysInMonth(11, 5439));
        }

        [TestMethod()]
        public void februaryInLeapYear()
        {
            Assert.AreEqual(29, gdim.getNumberOfDaysInMonth(2, 400));
        }

        [TestMethod()]
        public void februaryInNonLeapYear()
        {
            Assert.AreEqual(28, gdim.getNumberOfDaysInMonth(2, 200));
        }

        [TestMethod()]
        public void invalidMonthValueNegativeNumber()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(-23, 2017));
        }

        [TestMethod()]
        public void invalidMonthValueAboveMaxValue()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(15, 2017));
        }



        /// <summary>
        /// EQUIVALENCE TEST CASES FOR YEARS
        /// </summary>
        
        [TestMethod()]
        public void validYear()
        {
            Assert.AreNotEqual(-1, gdim.getNumberOfDaysInMonth(4, 1955));
        }

        [TestMethod()]
        public void isLeapYear()
        {
            Assert.AreEqual(29, gdim.getNumberOfDaysInMonth(2, 400));
        }

        [TestMethod()]
        public void isNonLeapYear()
        {
            Assert.AreEqual(28, gdim.getNumberOfDaysInMonth(2, 200));
        }

        [TestMethod()]
        public void invalidYearNegative()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(2, -29));
        }

        [TestMethod()]
        public void invalidYearAboveMaxValue()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(2, int.MaxValue));
        }



        /// <summary>
        /// BOUNDARY TEST CASES FOR MONTHS
        /// </summary>

        [TestMethod()]
        public void boundaryAroundMonthOne()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(0, 1955));
            Assert.AreNotEqual(-1, gdim.getNumberOfDaysInMonth(1, 1955));
        }

        [TestMethod()]
        public void boundaryAroundMonthTwelve()
        {
            Assert.AreNotEqual(-1, gdim.getNumberOfDaysInMonth(12, 1955));
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(13, 1955));
        }




        /// <summary>
        /// BOUNDARY TEST CASES FOR YEARS
        /// </summary>

        [TestMethod()]
        public void boundaryAroundYearOne()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(6, 0));
            Assert.AreNotEqual(-1, gdim.getNumberOfDaysInMonth(6, 1));
        }

        [TestMethod()]
        public void boundaryAroundMaxYearValue()
        {
            Assert.AreEqual(-1, gdim.getNumberOfDaysInMonth(6, int.MaxValue));
            Assert.AreNotEqual(-1, gdim.getNumberOfDaysInMonth(6, int.MaxValue-1));
        }

        [TestMethod()]
        public void boundaryLeapYears()
        {
            Assert.AreEqual(29, gdim.getNumberOfDaysInMonth(2, 4));
            Assert.AreNotEqual(29, gdim.getNumberOfDaysInMonth(2, 100));
            Assert.AreEqual(29, gdim.getNumberOfDaysInMonth(2, 400));
        }
    }
}