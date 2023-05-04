using System.Collections.ObjectModel;
using System.Linq;

namespace Lab_2.Model
{
    class TableShow: ObservableCollection<RowShow>
    {
        public bool CheckName(string? name)
        {
            return this.Any(p => p.Name == name);
        }
        public bool CheckIdShow(int idShow)
        {
            return this.Any(el => el.IdShow == idShow);
        }
    }
}
