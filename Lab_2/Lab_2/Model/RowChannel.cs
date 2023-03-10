using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Model.Enums
{
    class RowChannel
    {


        private static int counter;
        public int IdChannel { get; set; }
        public string Name { get; set; }
        public TypeChannel ChannelType { get; set; }
        public double Frequency { get; set; }

        public RowChannel(string name, TypeChannel channelType, double frequency)
        {
            IdChannel = counter++;
            Name = name;
            ChannelType = channelType;
            Frequency = frequency;
        }
    }
}
