using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CGPACalculator;
using System.Diagnostics;

namespace UnitTesterCGPA
{
    [TestClass]
    public class UnitTesterCGPA
    {
        [TestMethod]
        public void TestMethod1()
        {
            var marksList = new List<double> { 90, 70, 90 };
            int numOfCourses = 3;

            var program = new Program();
            string actualClassifier = program.calculateCGPA(marksList, numOfCourses);
            Assert.AreEqual(actualClassifier, "Merit");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var marksList = new List<double> { 90, 70, 50, 10 };
            int numOfCourses = 4;

            var program = new Program();
            string actualClassifier = program.calculateCGPA(marksList, numOfCourses);
            Assert.AreEqual("FirstClass", actualClassifier);
        }
    }
}

