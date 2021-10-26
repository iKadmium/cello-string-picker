using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelloStringPicker
{
	public class CelloString
	{
		public string Name { get; set; }
		public double LinearDensity { get; set; }

		public CelloString(string name, double frequency, double tension, double scaleLength)
		{
			Name = name;
			LinearDensity = Constants.Gravity * tension / (4 * Math.Pow(frequency, 2) * Math.Pow(scaleLength, 2));
		}

		public double GetTension(double scaleLength, double frequency)
		{
			var tension = Math.Pow(frequency * 2 * scaleLength, 2) * LinearDensity / Constants.Gravity;
			return tension;
		}
	}
}