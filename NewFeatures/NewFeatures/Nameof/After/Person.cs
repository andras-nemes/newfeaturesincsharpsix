using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.Nameof.After
{
	public class Person
	{
		public int Age { get; }
		public string FirstName { get; }
		public string LastName { get; }

		public Person(string firstName, string lastName, int age)
		{
			if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName));
			if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));
			if (age <= 0) throw new ArgumentException(nameof(age));
			//nameof works with properties and methods as well
			//string funcName = nameof(Greet);
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public void Greet()
		{

		}
	}
}
