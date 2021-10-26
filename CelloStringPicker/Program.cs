using System;
using System.Collections.Generic;

namespace CelloStringPicker
{
	class Program
	{
		static void Main(string[] args)
		{
			var library = new StringLibrary();
			library.Sets.Add(new StringSet("Prelude 4/4", Constants.ScaleLengths.FullSize, 28d, 29d, 30d, 31.8d));
			library.Sets.Add(new StringSet("Prelude 3/4", Constants.ScaleLengths.ThreeQuarter, 26.5d, 26.5d, 26.5d, 30d));
			library.Sets.Add(new StringSet("Prelude 1/2", Constants.ScaleLengths.Half, 24d, 25d, 23.5d, 27d));

			var strings = new List<FindStringResult>
			{
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.B1, 27d),
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.E2, 28d),
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.A2, 29d),
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.D3, 30d),
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.FS3, 31d),
				library.FindString(Constants.ScaleLengths.Arpeggione, Constants.Notes.B3, 32d)
			};

			foreach (var str in strings)
			{
				Console.WriteLine($"{str.String.Name} - {str.DesiredTension.ToString("F1")} => {str.ActualTension.ToString("F1")} ({(str.ActualTension * 100 / str.DesiredTension).ToString("F1")})%");
			}
		}
	}
}
