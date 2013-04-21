using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McPeak.Media.Aquos.Test
{
    [TestClass]
    public class AquosCommandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowsExceptionForNullCommand()
        {
            var cmd = new AquosCommand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CommandIsTooLong()
        {
            var cmd = new AquosCommand("AAAAA");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void ParameterTooLong()
        {
            var cmd = new AquosCommand("AAAA", "BBBBB");
        }

        [TestMethod]
        public void ParameterIsFourCharactersWhenNotPassed()
        {
            var cmd = new AquosCommand("AAAA");

            Assert.AreEqual("    ", cmd.Parameter);
        }

        [TestMethod]
        public void CommandOutputIsEightCharacters()
        {
            var cmd = new AquosCommand("AAAA", "Z");
            Assert.AreEqual(cmd.ToString().Length, 8);
        }

        [TestMethod]
        public void CommandIsEqualToCommand()
        {
            var cmd1 = new AquosCommand("AAAA", "B");
            var cmd2 = new AquosCommand("AAAA", "B");

            Assert.AreEqual(cmd1, cmd2);
        }

        [TestMethod]
        public void CommandIsNotEqualToCommand()
        {
            var cmd1 = new AquosCommand("AAAA", "B");
            var cmd2 = new AquosCommand("AAAA", "C");
            var cmd3 = new AquosCommand("AAAA", "Z");

            Assert.AreNotEqual(cmd1, cmd2);
            Assert.AreNotEqual(cmd1, cmd3);
            Assert.AreNotEqual(cmd2, cmd3);
        }

        [TestMethod]
        public void EqualsReturnsFalseWhenArgumentIsNull()
        {
            var cmd = new AquosCommand("AAAA");

            Assert.IsFalse(cmd.Equals(null));
        }

        [TestMethod]
        public void GetHashCodeIsNotZero()
        {
            var cmd = new AquosCommand("AAAA");

            Assert.IsTrue(cmd.GetHashCode() != 0);
        }

        [TestMethod]
        public void EqualityOperatorWorksCorrectly()
        {
            var cmd1 = new AquosCommand("AAAA", "B");
            var cmd2 = new AquosCommand("AAAA", "B");
            var cmd3 = new AquosCommand("AAAA", "C");

            Assert.IsTrue(cmd1 == cmd2);
            Assert.IsFalse(cmd1 == cmd3);
        }

        [TestMethod]
        public void InequalityOperatorWorksCorrectly()
        {
            var cmd1 = new AquosCommand("AAAA");
            var cmd2 = new AquosCommand("AAAA", "B");

            Assert.IsTrue(cmd1 != cmd2);
            Assert.IsFalse(cmd1 != cmd1);
        }
    }
}
