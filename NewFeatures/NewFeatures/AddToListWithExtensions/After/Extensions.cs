using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.AddToListWithExtensions.After
{
	public static class Extensions
	{
		//We can make that code shorter and adding the items less tedious by an extension method on a List of Rockband objects.
		//The extension method must be called "Add" and must accept the input parameters necessary for object construction
		public static void Add(this List<Rockband> rockbands, string name, int numberOfMembers)
		{			
			rockbands.Add(new Rockband(name, numberOfMembers));
			//We can even use the Add method to filter out unwanted elements. 
			//Let's say that we only accept rock bands with at least 5 members
			/*
			if (numberOfMembers > 4)
			{
				rockbands.Add(new Rockband(name, numberOfMembers));
			}*/
		}
	}
}
