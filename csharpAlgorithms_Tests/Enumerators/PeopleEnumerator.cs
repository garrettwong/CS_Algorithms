
using System;
using System.Collections;
using csharpAlgorithms.Enumerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    [TestClass]
    public class PeopleEnumerator_Tests
    {
        [TestMethod]
        public void PeopleEnum_Test()
        {
            BasicPerson[] peopleArray = new BasicPerson[3]
            {
                new BasicPerson("John", "Smith"),
                new BasicPerson("Jim", "Johnson"),
                new BasicPerson("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (BasicPerson p in peopleList)
            {
                Assert.AreNotEqual(p.FirstName + " " + p.LastName, "");
            }
        }
    }
}
