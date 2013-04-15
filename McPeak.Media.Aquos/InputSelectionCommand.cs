using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class InputSelectionCommand : AquosCommand
    {
        private const string COMMAND_STR = "IAVD";
        
        private InputSelectionCommand(Selection selection)
            : base(COMMAND_STR)
        {
            Parms = Convert.ToString((int) selection).PadRight(8);
        }

        public static InputSelectionCommand Hdmi1
        {
            get { return new InputSelectionCommand(Selection.Hdmi1); }
        }

        public static InputSelectionCommand Hdmi2
        {
            get { return new InputSelectionCommand(Selection.Hdmi2); }
        }

        public static InputSelectionCommand Hdmi3
        {
            get { return new InputSelectionCommand(Selection.Hdmi3); }
        }

        public static InputSelectionCommand Hdmi4
        {
            get { return new InputSelectionCommand(Selection.Hdmi4); }
        }

        public static InputSelectionCommand Component
        {
            get { return new InputSelectionCommand(Selection.Component); }
        }

        public static InputSelectionCommand Video1
        {
            get { return new InputSelectionCommand(Selection.Video1); }
        }

        public static InputSelectionCommand Video2
        {
            get { return new InputSelectionCommand(Selection.Video2); }
        }

        private enum Selection
        {
            Hdmi1 = 1,
            Hdmi2,
            Hdmi3,
            Hdmi4,
            Component,
            Video1,
            Video2
        }

    }
}
