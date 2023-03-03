using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Lab_2.Components
{
    public partial class Table_example : UserControl
    {
        public Table_example()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rowGroup = tblDummyData.RowGroups.FirstOrDefault();

            if (rowGroup != null)
            {
                TableRow row = new TableRow();

                TableCell cell = new TableCell();

                cell.Blocks.Add(new Paragraph(new Run("New Cell 1")));
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Blocks.Add(new Paragraph(new Run("New cell 2")));
                cell.Blocks.Add( new Paragraph(new Run("New cell 2")));
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Blocks.Add(new Paragraph(new Run("New cell 3")));
                row.Cells.Add(cell);

                rowGroup.Rows.Add(row);
            }
        }
    }
}

