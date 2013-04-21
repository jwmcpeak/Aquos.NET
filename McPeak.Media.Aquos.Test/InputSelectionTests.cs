using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class InputSelectionTests
    {
        [TestMethod]
        public void CommandHdmi1HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Hdmi1);
            var expectedValue = "IAVD1   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi2HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Hdmi2);
            var expectedValue = "IAVD2   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi3HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Hdmi3);
            var expectedValue = "IAVD3   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi4HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Hdmi4);
            var expectedValue = "IAVD4   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandComponentHasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Component);
            var expectedValue = "IAVD5   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo1HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Video1);
            var expectedValue = "IAVD6   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo2HasCorrectValue()
        {
            var cmd = AquosCommand.Input(InputSelection.Video2);
            var expectedValue = "IAVD7   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }
    }
}
