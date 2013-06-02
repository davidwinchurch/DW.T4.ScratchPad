namespace DW.T4.ScratchPad.Model.v001
{
    public class Trade
    {
        public int Id { get; private set; }

        public int Quantity { get; private set; }

        public Currency Currency { get; set; }
    }
}