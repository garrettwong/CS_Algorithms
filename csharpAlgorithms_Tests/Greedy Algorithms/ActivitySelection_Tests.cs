
using System.Collections.Generic;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    /// <summary>
    /// http://www.geeksforgeeks.org/greedy-algorithms-set-1-activity-selection-problem/
    /// </summary>
    [TestClass]
    public class ActivitySelectionTests
    {
        /// <summary>
        /// Consider the following 6 activities.
        /// start[]  =  {1, 3, 0, 5, 8, 5};
        /// finish[] =  {2, 4, 6, 7, 9, 9};
        /// The maximum set of activities that can be executed by a single person is {0, 1, 3, 4}
        /// </summary>
        [TestMethod]
        public void Test_GetMaxActivities()
        {
            var result = (new ActivitySelection()).GetMaxActivities(new int[] { 1, 3, 0, 5, 8, 5 }, new int[] { 2, 4, 6, 7, 9, 9 }, 6);
            
            CollectionAssert.AreEqual(result, new int[] { 0, 1, 3, 4 });
        }
    }
}
