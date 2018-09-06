
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharpAlgorithms.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    [TestClass]
    public class MultiSearch_Tests
    {
        [TestMethod]
        public void MultiSearch_Test()
        {
            var ms = new MultiSearch();

            var resultSet = ms.Find("mississippi", new string[] { "is", "ppi", "hi", "sis", "i", "ssippi" });

            Assert.IsTrue(resultSet.Keys.Contains("is"));
        }
    }
}
