using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CGPACalculator;

namespace CGPACalculatorUnitTester
{
    [TestClass]
    public class CGPACalculatorUnitTester
    {
        [TestMethod]
        public void CGPATester()
        {
            var marksList = new List<double> { 80, 75, 90, 85 };
            int numOfCourses = 4;
            double expectedCGPA = 7.5;

            var program = new Program();
            program.calculateCGPA(marksList, numOfCourses);
            double actualCGPA = CGPACalculator.CalculateCGPA(marksList, numOfCourses);

            Assert.AreEqual(expectedCGPA, actualCGPA);
        }

    }
}
