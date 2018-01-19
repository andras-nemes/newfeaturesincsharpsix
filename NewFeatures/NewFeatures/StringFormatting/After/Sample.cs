using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.StringFormatting.After
{
	class Sample
	{
		public void RunSample()
		{
			Rockband metallica = new Rockband("Metallica", 4, 50);
			string formatExampleTwo = $"The band is called {metallica.Name}, they have the fancy name of {metallica.GetFancyName()}, they have {metallica.NumberOfMembers} members and require {metallica.ConcertFee:c} for a concert.";
		}
	}
}
