using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.AddToListWithExtensions.Before
{
	class Sample
	{
		public void RunSample()
		{
			//add items during initialisation
			List<Rockband> rockbands = new List<Rockband>()
			{
				new Rockband("Queen", 4),
				new Rockband("Genesis", 5),
				new Rockband("Metallica", 4)
			};
		}
	}
}
