using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.Nameof.Before
{
	public class Person
	{
		public int Age { get; }
		public string FirstName { get; }
		public string LastName { get; }

		public Person(string firstName, string lastName, int age)
		{
			if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException("firstName");
			if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException("lastName");
			//need to change in the string input parameter if constructor params change
			if (age <= 0) throw new ArgumentException("age");
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}
	}
}
