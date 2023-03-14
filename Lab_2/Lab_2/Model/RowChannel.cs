using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Model.Enums
{
    class RowChannel
    {
        private static int _counter;
        public int IdChannel { get; set; }
        public string Name { get; set; }
        public TypeChannel ChannelType { get; set; }
        public double Frequency { get; set; }

        public RowChannel(string name, TypeChannel channelType, double frequency)
        {
            IdChannel = _counter++;
            Name = name;
            ChannelType = channelType;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"Name {Name}" +
                   $"ChannelType {ChannelType}";
        }
    }
}
