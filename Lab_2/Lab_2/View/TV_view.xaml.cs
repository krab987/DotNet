using System;
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
        TableBroadcast tableBroadcast = new TableBroadcast()
        {
            new RowBroadcast(
                new DateTime(2023,01,13,20,00,00), 
                    new DateTime(2023,01,13,21,30,00),
                    2,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,13,21,00,00), 
                    new DateTime(2023,01,13,23,20,00),
                    3,
                    2),
            new RowBroadcast(
                new DateTime(2023,01,13,07,00,00), 
                    new DateTime(2023,01,13,09,10,00),
                    3,
                    3),
            new RowBroadcast(
                new DateTime(2023,01,13,09,30,00), 
                    new DateTime(2023,01,13,10,30,00),
                    2,
                    4),
            new RowBroadcast(
                new DateTime(2023,01,13,10,00,00), 
                    new DateTime(2023,01,13,11,20,00),
                    1,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,13,08,00,00), 
                    new DateTime(2023,01,13,09,30,00),
                    1,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,13,12,00,00), 
                    new DateTime(2023,01,13,14,00,00),
                    6,
                    7),
            new RowBroadcast(
                new DateTime(2023,01,13,12,20,00), 
                    new DateTime(2023,01,13,15,00,00),
                    8,
                    8),
            new RowBroadcast(
                new DateTime(2023,01,13,18,00,00), 
                    new DateTime(2023,01,13,20,30,00),
                    11,
                    9),
            new RowBroadcast(
                new DateTime(2023,01,13,19,00,00), 
                    new DateTime(2023,01,13,22,10,00),
                    8,
                    10),
            new RowBroadcast(
                new DateTime(2023,01,13,06,00,00), 
                    new DateTime(2023,01,13,08,00,00),
                    10,
                    11),
            new RowBroadcast(
                new DateTime(2023,01,13,12,00,00), 
                    new DateTime(2023,01,13,14,00,00),
                    9,
                    7),
            new RowBroadcast(
                new DateTime(2023,01,13,14,30,00), 
                    new DateTime(2023,01,13,16,00,00),
                    5,
                    8),
            new RowBroadcast(
                new DateTime(2023,01,13,18,00,00), 
                    new DateTime(2023,01,13,20,30,00),
                    9,
                    9),
            new RowBroadcast(
                new DateTime(2023,01,13,03,20,00), 
                    new DateTime(2023,01,13,05,40,00),
                    5,
                    10),
            new RowBroadcast(
                new DateTime(2023,01,13,06,00,00), 
                    new DateTime(2023,01,13,08,00,00),
                    5,
                    11),
            new RowBroadcast(
                new DateTime(2023,01,13,10,00,00), 
                    new DateTime(2023,01,13,11,20,00),
                    4,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,13,08,00,00), 
                    new DateTime(2023,01,13,09,30,00),
                    4,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,13,12,00,00), 
                    new DateTime(2023,01,13,14,00,00),
                    4,
                    7),
            new RowBroadcast(
                new DateTime(2023,01,13,12,20,00), 
                    new DateTime(2023,01,13,15,00,00),
                    7,
                    8),
            new RowBroadcast(
                new DateTime(2023,02,24,10,30,00), 
                    new DateTime(2023,02,24,12,00,00),
                    5,
                    11),
            new RowBroadcast(
                new DateTime(2023,02,24,15,00,00), 
                    new DateTime(2023,02,24,17,00,00),
                    5,
                    8),
            new RowBroadcast(
                new DateTime(2023,02,24,13,30,00), 
                    new DateTime(2023,02,24,15,20,00),
                    3,
                    4),
            new RowBroadcast(
                new DateTime(2023,02,24,21,20,00), 
                    new DateTime(2023,02,24,23,30,00),
                    3,
                    6),
            new RowBroadcast(
                new DateTime(2023,02,24,11,30,00), 
                    new DateTime(2023,02,24,13,30,00),
                    5,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,15,07,00,00), 
                    new DateTime(2023,01,15,08,30,00),
                    8,
                    10),
            new RowBroadcast(
                new DateTime(2023,01,15,10,00,00), 
                    new DateTime(2023,01,15,12,20,00),
                    4,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,15,10,00,00), 
                    new DateTime(2023,01,15,12,20,00),
                    5,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,15,10,00,00), 
                    new DateTime(2023,01,15,12,20,00),
                    1,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,15,07,00,00), 
                    new DateTime(2023,01,15,08,30,00),
                    2,
                    10),
            new RowBroadcast(
                new DateTime(2023,01,17,07,00,00), 
                    new DateTime(2023,01,17,08,30,00),
                    9,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,17,07,00,00), 
                    new DateTime(2023,01,17,08,30,00),
                    4,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,17,07,00,00), 
                    new DateTime(2023,01,17,08,30,00),
                    2,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,17,07,00,00), 
                    new DateTime(2023,01,17,08,30,00),
                    3,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,19,07,00,00), 
                    new DateTime(2023,01,19,08,30,00),
                    2,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,19,07,00,00), 
                    new DateTime(2023,01,19,08,30,00),
                    3,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,19,07,00,00), 
                    new DateTime(2023,01,19,08,30,00),
                    1,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,19,07,00,00), 
                    new DateTime(2023,01,19,08,30,00),
                    9,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,20,21,00,00), 
                    new DateTime(2023,01,20,23,30,00),
                    3,
                    2),
            new RowBroadcast(
                new DateTime(2023,01,20,21,00,00), 
                    new DateTime(2023,01,20,23,30,00),
                    2,
                    3),
            new RowBroadcast(
                new DateTime(2023,01,20,21,00,00), 
                    new DateTime(2023,01,20,23,30,00),
                    1,
                    2),
            new RowBroadcast(
                new DateTime(2023,01,20,21,00,00), 
                    new DateTime(2023,01,20,23,30,00),
                    8,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,20,21,00,00), 
                    new DateTime(2023,01,20,23,30,00),
                    11,
                    4),
            new RowBroadcast(
                new DateTime(2023,01,13,08,20,00), 
                    new DateTime(2023,01,13,09,20,00),
                    5,
                    5),
            new RowBroadcast(
                new DateTime(2023,01,13,09,40,00), 
                    new DateTime(2023,01,13,11,40,00),
                    5,
                    2),
            new RowBroadcast(
                new DateTime(2023,01,13,12,00,00), 
                    new DateTime(2023,01,13,14,10,00),
                    5,
                    7),
            new RowBroadcast(
                new DateTime(2023,01,13,16,20,00), 
                    new DateTime(2023,01,13,17,50,00),
                    5,
                    1),
            new RowBroadcast(
                new DateTime(2023,01,13,18,10,00), 
                    new DateTime(2023,01,13,19,50,00),
                    5,
                    6),
            new RowBroadcast(
                new DateTime(2023,01,13,20,10,00), 
                    new DateTime(2023,01,13,21,40,00),
                    5,
                    3)
        }; // fill tableBroadcast

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

        private void TVBroadcast_Button_OnClick(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = (string)TVBroadcast_Button.Content;
            MainDataGrid.ItemsSource = tableBroadcast;
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

