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
            var min = VolumeCommand.Min;
            var max = VolumeCommand.Max;

            Assert.AreEqual(min.ToString().Length, 8);
            Assert.AreEqual(max.ToString().Length, 8);
        }

        [TestMethod]
        public void CommandisCorrect()
        {
            var minExpectedValue = "VOLM0".PadRight(8);
            var maxExpectedValue = "VOLM60".PadRight(8);
            var customExpectedValue = "VOLM30".PadRight(8);

            Assert.AreEqual(minExpectedValue, VolumeCommand.Min.ToString());
            Assert.AreEqual(maxExpectedValue, VolumeCommand.Max.ToString());
            Assert.AreEqual(customExpectedValue, VolumeCommand.Volume(30).ToString());
        }

        [TestMethod]
        public void CommandEqualsCommand()
        {
            Assert.AreEqual(VolumeCommand.Volume(30), VolumeCommand.Volume(30));
        }

        [TestMethod]
        public void CommandIsNotEqual()
        {
            Assert.AreNotEqual(VolumeCommand.Volume(30), VolumeCommand.Volume(31));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooHigh()
        {
            VolumeCommand.Volume(61);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowOutofRangeExceptionTooLow()
        {
            VolumeCommand.Volume(-1);
        }
    }
}
