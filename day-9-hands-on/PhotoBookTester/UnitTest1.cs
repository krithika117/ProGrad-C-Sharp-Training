using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using day_9_hands_on;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PhotoBookTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PhotoBook book = new PhotoBook();
            int result = book.GetPages();
            Assert.AreEqual(result, 16);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PhotoBook book = new PhotoBook(32);
            int result = book.GetPages();
            Assert.AreEqual(result, 32);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AddPhotoBook largeBook = new AddPhotoBook();
            int result = largeBook.GetPages();
            Assert.AreEqual(result, 64);
        }

        [TestMethod]
        public void TestMethod4()
        {
            AddPhotoBook largeBook = new AddPhotoBook();
            int result = largeBook.GetPages();
            Assert.AreEqual(result, 70);
        }
        [TestMethod]
        public void TestMethod5()
        {
            PhotoBook book = new PhotoBook(30);
            int result = book.GetPages();
            Assert.AreEqual(result, 32);
        }
    }
}