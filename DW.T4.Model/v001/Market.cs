namespace DW.T4.ScratchPad.Model.v001
{
    public class Market
    {
        public Market(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
    }
}