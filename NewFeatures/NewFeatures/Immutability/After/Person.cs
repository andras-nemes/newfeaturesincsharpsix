using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.Immutability.After
{
	public class Person
	{
		//The Age and Name fields can be set in the constructor but not anywhere else. 
		public int Age { get; }
		public string Name { get; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Greet()
		{
			//Name cannot be modified
			//Name = "Jill";
			return string.Format("Hello from {0}", Name);
		}
	}
}
