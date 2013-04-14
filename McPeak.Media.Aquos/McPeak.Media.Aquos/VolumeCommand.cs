using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class VolumeCommand : AquosCommand
    {
        private const string COMMAND_STR = "VOLM";

        private VolumeCommand(string parms) :
            base(COMMAND_STR, parms)
        {

        }

        private VolumeCommand(int value) :
            base(COMMAND_STR)
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentOutOfRangeException("Volume can only be between 0 and 60");
            }

            Parms = value.ToString()
                          .PadRight(4);
        }

        public static AquosCommand Min
        {
            get { return new VolumeCommand(0); }
        }

        public static AquosCommand Max
        {
            get { return new VolumeCommand(60); }
        }

        public static VolumeCommand Volume(int value)
        {
            return new VolumeCommand(value);
        }
    }
}
