using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Model.Enums;

namespace Lab_2.Model
{
    class RowBroadcast
    {
        private static int _counter;
        public int IdBroadcast { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public int IdChannel { get; set; }
        public int IdShow { get; set; }

        public RowBroadcast(DateTime beginning, DateTime ending, int idChannel, int idShow)
        {
            IdBroadcast = _counter++;
            Beginning = beginning;
            Ending = ending;
            IdChannel = idChannel;
            IdShow = idShow;
            if (ending <= beginning)
                throw new Exception("Ending mast be >= Beginning");
        }
    }
}
