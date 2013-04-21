using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class PowerCommandTests
    {
        [TestMethod]
        public void PowerOffCommandIsCorrect()
        {
            var expectedValue = "POWR0".PadRight(8);
            var cmd = AquosCommand.Power(PowerSetting.Off);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }

        [TestMethod]
        public void PowerOnCommandIsCorrect()
        {
            var expectedValue = "POWR1".PadRight(8);
            var cmd = AquosCommand.Power(PowerSetting.On);

            Assert.AreEqual(expectedValue, cmd.ToString());
        }
    }
}
