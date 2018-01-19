using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.ExpressionBodiedMembers.Before
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

		//Note that the "get" body is very simple, it's only one line.
		public string FullName
		{
			get
			{
				return string.Format("{0} {1}", FirstName, LastName);
			}
		}

		public bool Old
		{
			get
			{
				return Age > 35;
			}
		}

		public void WalkDog(Dog dog)
		{
			Console.WriteLine("I'm taking {0} out for a walk", dog.Name);
		}

		public int GetCombinedAge(Dog dog)
		{
			return Age + dog.Age;
		}
	}
}
