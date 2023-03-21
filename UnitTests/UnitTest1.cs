using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeoSmart.Geographical;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class WellKnownTests
    {
        [TestMethod]
        public void TestEnumerator()
        {
            var countries = WellKnown.Countries.ToList();
            Assert.IsTrue(countries.Count > 0);
        }

        [TestMethod]
        public void TestIndexer()
        {
            Assert.AreEqual(WellKnown.Countries.Afghanistan, WellKnown.Countries.Find("afghanistan"));
            Assert.AreEqual(WellKnown.Countries.Afghanistan, WellKnown.Countries.Find("AF"));
            Assert.AreEqual(WellKnown.Countries.Afghanistan, WellKnown.Countries.Find("af"));
        }
    }
}
