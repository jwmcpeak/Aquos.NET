using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class InputSelectionTests
    {
        [TestMethod]
        public void CommandOutputIsEightCharacters()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Hdmi1);
            Assert.AreEqual(cmd.ToString().Length, 8);
        }

        [TestMethod]
        public void CommandHdmi1HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Hdmi1);
            var expectedValue = "IAVD1   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi2HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Hdmi2);
            var expectedValue = "IAVD2   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi3HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Hdmi3);
            var expectedValue = "IAVD3   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi4HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Hdmi4);
            var expectedValue = "IAVD4   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandComponentHasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Component);
            var expectedValue = "IAVD5   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo1HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Video1);
            var expectedValue = "IAVD6   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo2HasCorrectValue()
        {
            var cmd = AquosCommand.SelectInput(InputSelection.Video2);
            var expectedValue = "IAVD7   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandIsEqualToCommand()
        {
            var cmd1 = AquosCommand.SelectInput(InputSelection.Hdmi1);
            var cmd2 = AquosCommand.SelectInput(InputSelection.Hdmi1);

            Assert.AreEqual(cmd1, cmd2);
        }
    }
}
