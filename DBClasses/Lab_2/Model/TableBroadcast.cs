using System.Collections.ObjectModel;
using System.Linq;

namespace Lab_2.Model
{
    class TableBroadcast : ObservableCollection<RowBroadcast>
    {
        public void DelRowByShow(int showId)
        {
            foreach (RowBroadcast el in this.ToList())
            {
                if (el.IdShow == showId)
                    Remove(el);
            }
        }

        public void DelRowByChannel(int channelId)
        {
            foreach (RowBroadcast el in this.ToList())
            {
                if (el.IdChannel == channelId)
                    Remove(el);
            }
        }
        public bool CheckUnique(RowBroadcast? row)
        {
            foreach (RowBroadcast el in this.ToList())
            {
                if(el.Equals(row) && el.IdBroadcast != row.IdBroadcast)
                    return true;
            }

            return false;
        }
    }

}
