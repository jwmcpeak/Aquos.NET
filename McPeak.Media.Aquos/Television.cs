using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class Television
    {
        public string IpAddress { get; set; }
        public int Port { get; set; }

        private const int MaxVolume = 60;

        public int Volume
        {
            set
            {
                if (value > MaxVolume || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Volume can only be between 0 and 60", new Exception());
                }

                var cmd = AquosCommand.Volume(value);
                IssueCommand(cmd);
            }
        }

        public InputSelection Input
        {
            set
            {
                var cmd = AquosCommand.Input(value);
                IssueCommand(cmd);
            }
        }

        public AvModeSelection AvMode
        {
            set
            {
                var cmd = AquosCommand.AvMode(value);
                IssueCommand(cmd);
            }
        }

        public Television(string ipAddress, int port)
        {

        }

        public bool Connect()
        {
            return false;
        }

        public void IssueCommand(AquosCommand command)
        {

        }
    }
}
