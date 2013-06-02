namespace DW.T4.Model.v001
{
    public class MarketDto
    {
        public MarketDto(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
    }
}