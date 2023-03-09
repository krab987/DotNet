using Domain.Enums;

namespace Domain
{
    public class TVShowRows
    {
        public TVShowRows()
        {
           // DataBase.Instance.Items.Add(this);
        }

        private static int counter = 0;
        public int Id { get; set; } = counter++;
        public string Name { get; set; } = "Name";
        public ShowTypes ShowType { get; set; } = ShowTypes.Мультфільм;
        public int DurationMin { get; set; } = 60;
        public ShowCathegorys ShowCathegory { get; set; } = ShowCathegorys.Зелений;
        
        
        public override string ToString()
        {
            return $"Id:{Id}, Name: '{Name}', ShowType: {ShowType} ";
        }
    }
}