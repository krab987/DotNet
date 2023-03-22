using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Lab_2.Model.Enums;

namespace Lab_2.Model
{
    class TableChannel: ObservableCollection<RowChannel>
    {

        public bool CheckName(string? name)
        {
            return this.Any(p => p.Name == name);
        }
        public bool CheckFreguency(double? frequency)
        {
            bool res = this.Any(p => p.Frequency == frequency);

            if(frequency is < 1000.0 or > 9999.9)
                res = true;
            return res;
        }
        public bool CheckIdChannel(int idChannel)
        {
            return this.Any(el => el.IdChannel == idChannel);
        }
    }
}
