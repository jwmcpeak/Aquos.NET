using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class VolumeTests
    {
        [TestMethod]
        public void CommandisCorrect()
        {
            var minExpectedValue = "VOLM0".PadRight(8);
            var maxExpectedValue = "VOLM60".PadRight(8);
            var customExpectedValue = "VOLM30".PadRight(8);

            Assert.AreEqual(minExpectedValue, AquosCommand.Volume(0).ToString());
            Assert.AreEqual(maxExpectedValue, AquosCommand.Volume(60).ToString());
            Assert.AreEqual(customExpectedValue, AquosCommand.Volume(30).ToString());
        }
    }
}
