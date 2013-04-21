using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class VolumeCommandTests
    {
        [TestMethod]
        public void CommandOutputIsEightCharacters()
        {
            var min = AquosCommand.Volume(0);
            var max = AquosCommand.Volume(60);

            Assert.AreEqual(min.ToString().Length, 8);
            Assert.AreEqual(max.ToString().Length, 8);
        }

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

        [TestMethod]
        public void CommandEqualsCommand()
        {
            Assert.AreEqual(AquosCommand.Volume(30), AquosCommand.Volume(30));
        }

        [TestMethod]
        public void CommandIsNotEqual()
        {
            Assert.AreNotEqual(AquosCommand.Volume(30), AquosCommand.Volume(31));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooHigh()
        {
            AquosCommand.Volume(61);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooLow()
        {
            AquosCommand.Volume(-1);
        }
    }
}
