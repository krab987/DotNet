using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Model
{
    class TableBroadcast : ObservableCollection<RowBroadcast>
    {
        public void DelRowByShow(int showId)
        {
            foreach (RowBroadcast el in this)
            {
                if (el.IdShow == showId)
                    Remove(el);
            }
        }

        public void DelRowByChannel(int channelId)
        {
            foreach (RowBroadcast el in this)
            {
                if (el.IdShow == channelId)
                    Remove(el);
            }
        }
    }

}
