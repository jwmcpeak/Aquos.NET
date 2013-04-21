using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McPeak.Media.Aquos
{
    public class Television
    {
        public string IPAddress { get; set; }
        public int Port { get; set; }

        private const int MAX_VOLUME = 60;

        public int Volume
        {
            set
            {
                if (value > MAX_VOLUME || value < 0)
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
                var cmd = AquosCommand.SelectInput(value);

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
