using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class AquosCommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        private const string VolumeCommandStr = "VOLM";

        protected string Cmd;
        protected string Parms;

        protected AquosCommand(string command, string parameters = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }

            if (string.IsNullOrEmpty(parameters))
            {
                parameters = string.Empty.PadRight(ParamMaxLength);
            }

            command = command.Trim();

            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            if (parameters.Length > ParamMaxLength)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters");
            }

            Cmd = command;
            Parms = parameters.PadRight(ParamMaxLength);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Cmd, Parms);
        }

        #region Equality Testing
        public override bool Equals(object obj)
        {
            return Equals(obj as AquosCommand);
        }

        public bool Equals(AquosCommand command)
        {
            if (command == null)
            {
                return false;
            }

            return ToString() == command.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(AquosCommand a, AquosCommand b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(AquosCommand a, AquosCommand b)
        {
            return !(a == b);
        } 
        #endregion

        #region Creation Methods
        public static AquosCommand Volume(int value)
        {
            return new AquosCommand(VolumeCommandStr, Convert.ToString(value));
        }
        #endregion
    }
}
