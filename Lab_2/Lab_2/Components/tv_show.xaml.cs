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

namespace Lab_2.Components
{
    /// <summary>
    /// Interaction logic for tv_show.xaml
    /// </summary>
    public partial class tv_show : UserControl
    {
        public tv_show()
        {
            InitializeComponent();
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            TableShow tableShow = new TableShow()
            {
                new RowShow("Хто зверху?", TypeShow.РозважальнаПередача, 90, CategoryShow.Червоний),
                new RowShow("Життя зірок", TypeShow.РозважальнаПередача, 120, CategoryShow.Зелений),
                new RowShow("Єдині. Головне", TypeShow.НауковоПопулярнаПередача, 90, CategoryShow.Зелений),
                new RowShow("Мауглі", TypeShow.Мультфільм, 129, CategoryShow.Жовтий),
                new RowShow("Хіти Non-Stop", TypeShow.РозважальнаПередача, 55, CategoryShow.Зелений),
                new RowShow("Леді Баг і Супер-Кіт", TypeShow.Мультфільм, 105, CategoryShow.Зелений),
                new RowShow("Інформаційний марафон", TypeShow.НауковоПопулярнаПередача, 130, CategoryShow.Жовтий),
                new RowShow("МайстерШеф. Професіонали", TypeShow.РозважальнаПередача, 90, CategoryShow.Червоний),
                new RowShow("Слідство ведуть екстрасенси", TypeShow.РозважальнаПередача, 120, CategoryShow.Жовтий),
                new RowShow( "Місія Блейк", TypeShow.Мультфільм, 140, CategoryShow.Зелений),
                new RowShow( "Оггі та кукарачі", TypeShow.Мультфільм, 120, CategoryShow.Зелений),
                new RowShow( "Супер мама", TypeShow.РозважальнаПередача, 60, CategoryShow.Жовтий)
            };
            grid.ItemsSource = tableShow;
        }

    }
}
