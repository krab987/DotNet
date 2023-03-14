using Lab_2.Model.Enums;
using Lab_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Channels;

namespace Lab_2.Components
{
    /// <summary>
    /// Interaction logic for tv_channel.xaml
    /// </summary>
    public partial class tv_channel : UserControl
    {
        public tv_channel()
        {
            InitializeComponent();
        }

        private void gridChannel_Loaded(object sender, RoutedEventArgs e)
        {
            TableChannel tableChannel = new TableChannel()
            {
                new RowChannel(" Про Все", TypeChannel.Супутниковий, 6543.2),
                new RowChannel("СТБ", TypeChannel.Національний, 1567.8),
                new RowChannel("1+1", TypeChannel.Національний, 2695.8),
                new RowChannel("Рада", TypeChannel.Національний, 9564.4),
                new RowChannel("Starlight Media", TypeChannel.Супутниковий, 9956.1),
                new RowChannel("Суспільне Культура", TypeChannel.Національний, 9563.4),
                new RowChannel("Інтер", TypeChannel.Національний, 2265.1),
                new RowChannel("Сонце", TypeChannel.Супутниковий, 9564.1),
                new RowChannel("Вільні", TypeChannel.Супутниковий, 7564.4),
                new RowChannel("ТЕТ", TypeChannel.Національний, 2649.7),
                new RowChannel("МЕГА", TypeChannel.Національний, 5554.7),
                new RowChannel("НТН", TypeChannel.Супутниковий, 9546.5)
            };
            gridChannel.ItemsSource = tableChannel;
        }
    }
}
