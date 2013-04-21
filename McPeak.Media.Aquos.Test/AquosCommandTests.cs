using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class AquosCommandTests
    {
        [TestMethod]
        public void CommandOutputIsEightCharacters()
        {
            var min = AquosCommand.Volume(0);
            var max = AquosCommand.Volume(60);
            var cmd = AquosCommand.Input(InputSelection.Hdmi1);


            Assert.AreEqual(min.ToString().Length, 8);
            Assert.AreEqual(max.ToString().Length, 8);
            Assert.AreEqual(cmd.ToString().Length, 8);
        }

        [TestMethod]
        public void CommandIsEqualToCommand()
        {
            var cmd1 = AquosCommand.Volume(0);
            var cmd2 = AquosCommand.Volume(0);

            var cmd3 = AquosCommand.Input(InputSelection.Hdmi3);
            var cmd4 = AquosCommand.Input(InputSelection.Hdmi3);


            Assert.AreEqual(cmd1, cmd2);
            Assert.AreEqual(cmd3, cmd4);
        }

        [TestMethod]
        public void CommandIsNotEqualToCommand()
        {
            var cmd1 = AquosCommand.Volume(0);
            var cmd2 = AquosCommand.Volume(1);
            var cmd3 = AquosCommand.Input(InputSelection.Hdmi1);

            Assert.AreNotEqual(cmd1, cmd2);
            Assert.AreNotEqual(cmd1, cmd3);
            Assert.AreNotEqual(cmd2, cmd3);
        }
    }
}
