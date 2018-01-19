using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;
using static System.Math;

namespace NewFeatures.UsingStaticMembers.After
{
	class Sample
	{
		public void RunSample()
		{
			string startingPoint = "Hello world";

			if (!IsNullOrEmpty(startingPoint))
			{
				string toBePrinted = Format("I am saying {0}", Join(",", startingPoint, "some other string"));
				Console.WriteLine(toBePrinted);
			}
			//example from System.Math
			double pi = PI;
		}
	}
}
