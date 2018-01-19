using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.AddToListWithExtensions
{
	public class Rockband
	{
		public string Name { get; }
		public int NumberOfMembers { get; }

		public Rockband(string name, int numberOfMembers)
		{
			Name = name;
			NumberOfMembers = numberOfMembers;
		}
	}
}
