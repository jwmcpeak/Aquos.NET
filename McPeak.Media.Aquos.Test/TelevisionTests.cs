using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooHigh()
        {
            var tv = new Television("", 10);
            tv.Volume = 61;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooLow()
        {
            var tv = new Television("", 10);
            tv.Volume = -1;
        }
    }
}
