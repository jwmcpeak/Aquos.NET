using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class AquosCommand
    {
        protected const int COMMAND_MAX_LENGTH = 4;
        protected const int PARAM_MAX_LENGTH = 4;

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
                parameters = string.Empty.PadRight(PARAM_MAX_LENGTH);
            }

            command = command.Trim();

            if (command.Length > COMMAND_MAX_LENGTH)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            if (parameters.Length > PARAM_MAX_LENGTH)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters");
            }

            Cmd = command;
            Parms = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Cmd, Parms);
        }

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
    }
}
