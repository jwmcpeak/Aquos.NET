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

        public const string VolumeCommand = "VOLM";
        public const string InputSelectionCommand = "IAVD";
        public const string AvModeSelectionCommand = "AVMD";
        public const string PowerSettingCommand = "POWR";

        public string Command { get; private set; }
        public string Parameter { get; private set; }

        public AquosCommand(string command, string parameters = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }

            command = command.Trim();

            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            if (string.IsNullOrEmpty(parameters))
            {
                parameters = string.Empty;
            }

            parameters = parameters.Trim();

            if (parameters.Length > ParamMaxLength)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters");
            }

            Command = command;
            Parameter = parameters.PadRight(ParamMaxLength);
        }

        public AquosCommand(string command, int value)
            : this(command, Convert.ToString(value))
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Command, Parameter);
        }

        #region Equality
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
            return new AquosCommand(VolumeCommand, value);
        }

        public static AquosCommand Input(InputSelection selection)
        {
            return new AquosCommand(InputSelectionCommand, (int) selection);
        }

        public static AquosCommand AvMode(AvModeSelection selection)
        {
            return new AquosCommand(AvModeSelectionCommand, (int) selection);
        }

        public static AquosCommand Power(PowerSetting setting)
        {
            return new AquosCommand(PowerSettingCommand, (int) setting);
        }
        #endregion
    }
}
