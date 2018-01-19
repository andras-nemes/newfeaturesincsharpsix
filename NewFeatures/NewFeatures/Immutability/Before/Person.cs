using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures.Immutability.Before
{
	public class Person
	{
		//The readonly keyword will make sure that the private properties can only be assigned from the constructor.
		private readonly string _name;
		private readonly int _age;

		public Person(string name, int age)
		{
			//can only set value in constructor
			_name = name;
			_age = age;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			//setter not allowed due to readonly keyword
			/*
			set
			{
				_name = value;
			}*/
		}

		public int Age
		{
			get
			{
				return _age;
			}
		}
	}
}
