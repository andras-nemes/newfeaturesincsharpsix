using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.ExpressionBodiedMembers.After
{
	public class Person
	{
		public int Age { get; }
		public string FirstName { get; }
		public string LastName { get; }

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		//expression bodied members for props
		public string FullName => string.Format("{0} {1}", FirstName, LastName);
		public bool Old => Age > 35;

		//expression bodied members for methods
		public void WalkDog(Dog dog) => Console.WriteLine("I'm taking {0} out for a walk", dog.Name);
		public int GetCombinedAge(Dog dog) => Age + dog.Age;
	}
}
