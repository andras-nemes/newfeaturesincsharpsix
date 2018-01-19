using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.Immutability.Before
{
	public class PersonAlternative
	{
		public int Age { get; private set; }
		public string Name { get; private set; }

		public PersonAlternative(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Greet()
		{
			//Name can still be modified internally, not 100% immutable
			Name = "Jill";
			return string.Format("Hello from {0}", Name);
		}
	}
}
