using System.Collections.Generic;

namespace Domain
{
    public class Table : List<TVShowRows> { }
    public class DataBase
    {
        public Table TableItem { get; }
        private static DataBase? database = null;
        public static DataBase Database
        { 
            get
            {
                if (database == null)
                    database = new DataBase();
                return database;
            }
        }
        
        private DataBase()
        {
            TableItem = new Table();
        }

    }
}
