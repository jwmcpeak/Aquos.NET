using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class InputSelectionCommandTests
    {
        [TestMethod]
        public void CommandOutputIsEightCharacters()
        {
            var cmd = InputSelectionCommand.Hdmi1;

            Assert.AreEqual(cmd.ToString().Length, 8);
        }

        [TestMethod]
        public void CommandHdmi1HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Hdmi1;
            var expectedValue = "IAVD1   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi2HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Hdmi2;
            var expectedValue = "IAVD2   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi3HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Hdmi3;
            var expectedValue = "IAVD3   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandHdmi4HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Hdmi4;
            var expectedValue = "IAVD4   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandComponentHasCorrectValue()
        {
            var cmd = InputSelectionCommand.Component;
            var expectedValue = "IAVD5   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo1HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Video1;
            var expectedValue = "IAVD6   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandVideo2HasCorrectValue()
        {
            var cmd = InputSelectionCommand.Video2;
            var expectedValue = "IAVD7   ";
            Assert.AreEqual(cmd.ToString(), expectedValue);
        }

        [TestMethod]
        public void CommandIsEqualToCommand()
        {
            var cmd1 = InputSelectionCommand.Hdmi1;
            var cmd2 = InputSelectionCommand.Hdmi1;

            Assert.AreEqual(cmd1, cmd2);
        }
    }
}
