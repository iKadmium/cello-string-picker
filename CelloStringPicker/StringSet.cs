using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelloStringPicker
{
	public class StringSet
	{
		public string Name { get; set; }
		public double ScaleLength { get; set; }
		public List<CelloString> Strings { get; }
		public StringSet(string name, double scaleLength, double cTension, double gTension, double dTension, double aTension)
		{
			Name = name;
			ScaleLength = scaleLength;
			Strings = new List<CelloString>
			{
				new CelloString($"{name} C", Constants.Notes.C2, cTension, scaleLength),
				new CelloString($"{name} G", Constants.Notes.G2, gTension, scaleLength),
				new CelloString($"{name} D", Constants.Notes.D3, dTension, scaleLength),
				new CelloString($"{name} A", Constants.Notes.A3, aTension, scaleLength)
			};
		}
	}
}