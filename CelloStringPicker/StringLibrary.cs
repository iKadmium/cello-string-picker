using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelloStringPicker
{
	public class FindStringResult
	{
		public double DesiredTension { get; set; }
		public double ActualTension { get; set; }
		public CelloString String { get; set; }
	}

	public class StringLibrary
	{
		public List<StringSet> Sets { get; }

		public StringLibrary()
		{
			Sets = new List<StringSet>();
		}

		public FindStringResult FindString(double scaleLength, double frequency, double tension)
		{
			var stringsByTension = Sets.SelectMany(x => x.Strings)
				.OrderBy(x => Math.Abs(x.GetTension(scaleLength, frequency) - tension));
			var str = stringsByTension.First();
			var result = new FindStringResult
			{
				DesiredTension = tension,
				ActualTension = str.GetTension(scaleLength, frequency),
				String = str
			};
			return result;
		}
	}
}