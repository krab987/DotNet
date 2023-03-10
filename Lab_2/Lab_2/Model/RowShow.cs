using Lab_2.Model.Enums;

namespace Lab_2.Model
{
    class RowShow
    {
        private static int counter;
        public int IdShow { get; set; }
        public string Name { get; set; }
        public TypeShow TypeShow { get; set; }
        public int Duration { get; set; }
        public CategoryShow ShowCategory { get; set; }

        public RowShow(string name, TypeShow typeShow, int duration, CategoryShow categoryShow)
        {
            IdShow = ++counter;
            Name = name;
            TypeShow = typeShow;
            Duration = duration;
            ShowCategory = categoryShow;
        }
    }
}
