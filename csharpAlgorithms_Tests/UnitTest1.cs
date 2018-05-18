using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestArrayEnum()
        {
            var ae = new ArrayEnumerator<int>(new int[] { 1, 2, 3});

            ae.MoveNext();
            Assert.AreEqual(1, ae.Current);
            ae.MoveNext();
            Assert.AreEqual(2, ae.Current);
            ae.MoveNext();
            Assert.AreEqual(3, ae.Current);
        }
    }
}
