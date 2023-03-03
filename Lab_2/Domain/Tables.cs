using System.Collections.Generic;

namespace Domain
{
    public class TableItem : List<Rows> { }
    public class DataBase
    {
        private static DataBase? instance = null;
        private DataBase()
        {
            Items = new TableItem();
        }

        public static DataBase Instance
        { 
            get
            {
                if (instance == null)
                    instance = new DataBase();
                return instance;
            }
        }

        public TableItem Items { get; }
    }
}
