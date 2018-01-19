using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.ExpressionBodiedMembers
{
	public class Dog
	{
		public string Name { get; }
		public int Age { get; }

		public Dog(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
