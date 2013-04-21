using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class AvModeTests
    {
        [TestMethod]
        public void ToggleCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Toggle);
            var expectedValue = "AVMD0".PadRight(8);


            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void StandardCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Standard);
            var expectedValue = "AVMD1".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void MovieCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Movie);
            var expectedValue = "AVMD2".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void GameCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Game);
            var expectedValue = "AVMD3".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void UserCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.User);
            var expectedValue = "AVMD4".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void DynamicFixedCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.DynamicFixed);
            var expectedValue = "AVMD5".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void DynamicCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Dynamic);
            var expectedValue = "AVMD6".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void PcCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Pc);
            var expectedValue = "AVMD7".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void XvColorCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.XvColor);
            var expectedValue = "AVMD8".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void AutoCommandIsCorrect()
        {
            var cmd = AquosCommand.AvMode(AvModeSelection.Auto);
            var expectedValue = "AVMD100".PadRight(8);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }
    }
}
