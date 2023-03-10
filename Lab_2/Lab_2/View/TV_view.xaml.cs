using Lab_2.Components;
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

        //private void AddRow_Click(object sender, RoutedEventArgs e)
        //{
        //    var rowGroup = tv_show.TblTvShow.RowGroups.FirstOrDefault();

        //    if (rowGroup != null)
        //    {
        //        TableRow row = new TableRow();
                
        //        TableCell cell = new TableCell();
        //        cell.Blocks.Add(new Paragraph(new Run("New Cell 1")));
        //        row.Cells.Add(cell);

        //        cell = new TableCell();
        //        cell.Blocks.Add(new Paragraph(new Run("New cell 2")));
        //        cell.Blocks.Add( new Paragraph(new Run("New cell 2")));
        //        row.Cells.Add(cell);

        //        cell = new TableCell();
        //        cell.Blocks.Add(new Paragraph(new Run("New cell 3")));
        //        row.Cells.Add(cell);

        //        rowGroup.Rows.Add(row);
        //    }
        //}
        private void AddRow_Click(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

