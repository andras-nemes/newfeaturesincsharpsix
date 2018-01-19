using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.StringFormatting.Before
{
	class Sample
	{
		public void RunSample()
		{
			Rockband metallica = new Rockband("Metallica", 4, 50);
			string formatExampleOne = string.Format("The band is called {0}, they have the fancy name of {1}, they have {2} members and require {3:c} for a concert."
				, metallica.Name, metallica.GetFancyName(), metallica.NumberOfMembers, metallica.ConcertFee);

			//sample output with locale en-UK:
			//The band is called Metallica, they have the fancy name of METALLICA, they have 4 members and require £50.00 for a concert.
		}
	}
}
