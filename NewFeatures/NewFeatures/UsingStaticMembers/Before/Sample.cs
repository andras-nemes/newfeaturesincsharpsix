using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.UsingStaticMembers.Before
{
	class Sample
	{
		public void RunSample()
		{
			string startingPoint = "Hello world";

			if (!string.IsNullOrEmpty(startingPoint))
			{
				string toBePrinted = string.Format("I am saying {0}", string.Join(",", startingPoint, "some other string"));
				Console.WriteLine(toBePrinted);
			}
		}
	}
}
