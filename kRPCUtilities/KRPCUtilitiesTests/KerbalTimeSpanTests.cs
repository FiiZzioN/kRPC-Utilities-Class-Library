using kRPCUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KRPCUtilitiesTests
{
    [TestClass]
    public class KerbalTimeSpanTests
    {
        private KerbalTimeSpan kerbalTimeSpan = new KerbalTimeSpan();

        [TestMethod]
        public void FoundationTestYears()
        {
            kerbalTimeSpan.FromYears(24);

            Assert.AreEqual(10225.92, kerbalTimeSpan.TotalDays);
            Assert.AreEqual(61355.52, kerbalTimeSpan.TotalHours, 0.00000000001);
            Assert.AreEqual(3681331.2, kerbalTimeSpan.TotalMinutes, 0.00000000001);
            Assert.AreEqual(220879872, kerbalTimeSpan.TotalSeconds, 0.00000000001);
        }

        [TestMethod]
        public void FoundationTestDays()
        {
            kerbalTimeSpan.FromDays(24);

            AssertCorrectConversion();
        }

        [TestMethod]
        public void FoundationTestHours()
        {
            kerbalTimeSpan.FromHours(144);

            AssertCorrectConversion();
        }

        [TestMethod]
        public void FoundationTestMinutes()
        {
            kerbalTimeSpan.FromMinutes(8640);

            AssertCorrectConversion();
        }

        [TestMethod]
        public void FoundationTestSeconds()
        {
            kerbalTimeSpan.FromSeconds(518400);

            AssertCorrectConversion();
        }

        private void AssertCorrectConversion()
        {
            Assert.AreEqual(24, kerbalTimeSpan.TotalDays);
            Assert.AreEqual(144, kerbalTimeSpan.TotalHours);
            Assert.AreEqual(8640, kerbalTimeSpan.TotalMinutes);
            Assert.AreEqual(518400, kerbalTimeSpan.TotalSeconds);
            Assert.AreEqual(0.0563, kerbalTimeSpan.TotalYears, 0.0001);
        }
    }
}