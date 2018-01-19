using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.StringFormatting
{
	public class Rockband
	{
		public string Name { get; }
		public int NumberOfMembers { get; }
		public decimal ConcertFee { get; }

		public Rockband(string name, int numberOfMembers, decimal concertFee)
		{
			Name = name;
			NumberOfMembers = numberOfMembers;
			ConcertFee = concertFee;
		}

		public string GetFancyName()
		{
			return Name.ToUpper();
		}
	}
}
