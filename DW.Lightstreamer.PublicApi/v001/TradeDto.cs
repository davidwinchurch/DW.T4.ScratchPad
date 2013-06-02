using System.Collections.Specialized;

namespace DW.Lightstreamer.PublicApi.v001
{
	public class TradeDto
	{
		public OrderedDictionary FieldNames = new OrderedDictionary
		{
			{ "Id", "i" },
			{ "Quantity", "q" },
			{ "Currency", "c" },
		};
	}
}
