namespace Domain
{
    public class Rows
    {
        public Rows()
        {
           // DataBase.Instance.Items.Add(this);
        }

        private static int counter = 0;
        public int Id { get; set; } = counter++;
        public string Name { get; set; } = "Name";
        public string Description { get; set; } = "Desc";
        public string Description2 { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Id:{Id}, Name: '{Name}' ({Description})";
        }
    }
}