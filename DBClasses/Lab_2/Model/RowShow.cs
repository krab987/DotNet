using Lab_2.Model.Enums;
using System;

namespace Lab_2.Model
{
    class RowShow
    {
        private static int counter;
        public int IdShow { get; set; }
        public string Name { get; set; }
        public TypeShow TypeShow { get; set; }
        public uint Duration { get; set; }
        public CategoryShow ShowCategory { get; set; }

        public RowShow(string name, TypeShow typeShow, uint duration, CategoryShow categoryShow)
        {
            IdShow = ++counter;
            Name = name;
            TypeShow = typeShow;
            Duration = duration;
            ShowCategory = categoryShow;
        }
        public RowShow()
        {
            IdShow = ++counter;
        }

    }
}
