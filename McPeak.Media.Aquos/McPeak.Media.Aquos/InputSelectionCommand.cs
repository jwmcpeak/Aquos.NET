using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class InputSelectionCommand : AquosCommand
    {
        private const string COMMAND_STR = "IAVD";
        private InputSelectionCommand(string parms) :
            base(COMMAND_STR, parms)
        {

        }

        private InputSelectionCommand(Selection value) :
            base(COMMAND_STR)
        {
            int selection = (int)value;


        }

        private enum Selection
        {
            HDMI1 = 1,
            HDMI2,
            HDMI3,
            HDMI4,
            Component,
            Video1,
            Video2
        }

    }
}
