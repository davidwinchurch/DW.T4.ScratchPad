using System.Collections.Specialized;

namespace DW.Lightstreamer.PublicApi.v001
{
	public class MarketDto
	{
		public OrderedDictionary FieldNames = new OrderedDictionary
		{
			{ "Id", "i" },
			{ "Name", "n" },
		};
	}
}
