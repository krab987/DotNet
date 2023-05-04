using System;
using Lab_2.Model.Enums;
using Lab_2.Model;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace Lab_2.View
{
    public partial class tvView : UserControl
    {
        public tvView()
        {
            InitializeComponent();
        }


        TableShow _tableShow = new TableShow()
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
                new RowShow("Місія Блейк", TypeShow.Мультфільм, 140, CategoryShow.Зелений),
                new RowShow("Оггі та кукарачі", TypeShow.Мультфільм, 120, CategoryShow.Зелений),
                new RowShow("Супер мама", TypeShow.РозважальнаПередача, 60, CategoryShow.Жовтий)
            }; // fill tableShow
        TableChannel _tableChannel = new TableChannel()
            {
                new RowChannel("Про Все", TypeChannel.Супутниковий, 6543.2),
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
        TableBroadcast _tableBroadcast = new TableBroadcast()
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

        private void MainDataGrid_OnLoaded(object? sender, RoutedEventArgs e)
        {
            MainDataGrid.ItemsSource = _tableShow;
            (((DataGrid)sender!)!).Columns[0].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
            (((DataGrid)sender!)!).Columns[0].MinWidth = 20;
        }

        #region Clicks Change tables
        private void TVShow_Click(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = TVShow_Button.Content.ToString();
            MainDataGrid.ItemsSource = _tableShow; 
            MainDataGrid.Columns[0].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
            MainDataGrid.Columns[0].MinWidth = 20;

        }
        private void TVChannel_Click(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = (string)TVChannel_Button.Content;
            MainDataGrid.ItemsSource = _tableChannel;
            MainDataGrid.Columns[0].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
            MainDataGrid.Columns[0].MinWidth = 20;
        }

        private void TVBroadcast_Button_OnClick(object sender, RoutedEventArgs e)
        {
            Title_Label.Text = (string)TVBroadcast_Button.Content;
            MainDataGrid.ItemsSource = _tableBroadcast;
            MainDataGrid.Columns[0].Width = new DataGridLength(1, DataGridLengthUnitType.Auto);
            MainDataGrid.Columns[0].MinWidth = 20;
        }
        #endregion
        #region Del/Add_Clicks
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedItem is RowShow selectedItem)
            {
                _tableShow.Remove(selectedItem);
                _tableBroadcast.DelRowByShow(selectedItem.IdShow);
            }
            if (MainDataGrid.SelectedItem is RowChannel selectedItemChannel)
            {
                _tableChannel.Remove(selectedItemChannel);
                _tableBroadcast.DelRowByChannel(selectedItemChannel.IdChannel);
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            new RowChannel();
            new RowShow();
            new RowBroadcast();

            if (Equals(MainDataGrid.ItemsSource, _tableBroadcast))
            {
                try
                {
                    if (_tableBroadcast.CheckUnique(MainDataGrid.Items.CurrentItem as RowBroadcast))
                        throw new Exception("Its fully duplicate");
                    RowBroadcast currentRowBroadcast = _tableBroadcast[_tableBroadcast.Count - 1];
                    if (currentRowBroadcast.Ending < currentRowBroadcast.Beginning || currentRowBroadcast.Ending == currentRowBroadcast.Beginning)
                        throw new Exception($"{currentRowBroadcast.Ending} less than {currentRowBroadcast.Beginning}");

                }
                catch (Exception ex)
                {
                    _tableBroadcast.Remove((MainDataGrid.Items.CurrentItem as RowBroadcast)!);
                    MessageBox.Show(ex.Message, "Error in input", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion

        private void GridShow_OnAutoGeneratingColumn(object? sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            MainDataGrid.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
            MainDataGrid.MinColumnWidth = 150;
        }

        private void MainDataGrid_OnCellEditEnding(object? sender, DataGridCellEditEndingEventArgs e)
        {
            var elText = (e.EditingElement as TextBox)?.Text;
            try
            {
                if (elText == String.Empty || elText == "0")
                    throw new Exception("It cant be empty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in input", MessageBoxButton.OK, MessageBoxImage.Error);
                e.Cancel = true;
            }

            if (Equals(MainDataGrid.ItemsSource, _tableChannel))
            {
                try
                {
                    if ((string)e.Column.Header == "Name" && _tableChannel.CheckName(elText))
                        throw new Exception($"{e.EditingElement} is exists");
                    if ((string)e.Column.Header == "Frequency" && _tableChannel.CheckFreguency(double.Parse(elText, CultureInfo.InvariantCulture)))
                        throw new Exception($"{e.EditingElement} <1000.0 or >9999.9");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in input", MessageBoxButton.OK, MessageBoxImage.Error);
                    e.Cancel = true;
                }
            }
            if (Equals(MainDataGrid.ItemsSource, _tableShow))
            {
                try
                {
                    if ((string)e.Column.Header == "Name" && _tableShow.CheckName(elText))
                        throw new Exception($"{e.EditingElement} is exists");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in input", MessageBoxButton.OK, MessageBoxImage.Error);
                    e.Cancel = true;
                }
            }
            if (Equals(MainDataGrid.ItemsSource, _tableBroadcast))
            {
                try
                {
                    if ((string)e.Column.Header == "IdShow" && !(_tableShow.CheckIdShow(int.Parse(elText))))
                        throw new Exception($"{e.EditingElement} is not exists in TV Shows");
                    if ((string)e.Column.Header == "IdChannel" && !(_tableChannel.CheckIdChannel(int.Parse(elText))))
                        throw new Exception($"{e.EditingElement} is not exists in TV Channels");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in input", MessageBoxButton.OK, MessageBoxImage.Error);
                    e.Cancel = true;
                }
            }


        }
    }
}

