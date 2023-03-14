using Lab_2.Components;
using Lab_2.Model.Enums;
using Lab_2.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Lab_2.View
{
    public partial class tvView : UserControl
    {
        public tvView()
        {
            InitializeComponent();
        }


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
            }; // fill tableShow
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
            }; // fill tableChannel

        private void MainDataGrid_OnLoaded(object sender, RoutedEventArgs e)
        {
            MainDataGrid.ItemsSource = tableShow;
        }

        private void TVShow_Click(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = TVShow_Button.Content.ToString();
            MainDataGrid.ItemsSource = tableShow;

        }
        private void TVChannel_Click(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = (string)TVChannel_Button.Content;
            MainDataGrid.ItemsSource = tableChannel;
        }




        private void GridShow_OnAutoGeneratingColumn(object? sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            ////Modify the header of the "Name" column
            //if (e.Column.Header.ToString() == "Name")
            //{
            //    e.Column.Header = "Task";
            //}
            ////Replace the DueDate column with a custom template column.
            //if (e.PropertyName == "DueDate")
            //{
            //    //Create a new template column.
            //    var templateColumn = new DataGridTemplateColumn();
            //    templateColumn.Header = "Due Date";
            //    //...
            //}
        }

    }
}

